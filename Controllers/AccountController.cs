using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using POS.APIs.Data;
using POS.APIs.Data.Models;
using POS.APIs.Models.DTO;

namespace POS.APIs.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly GLPOSContext _context;
        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            IConfiguration configuration,
            GLPOSContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.FindByEmailAsync(registration.Email);
            if (user != null)
            {
                SerializableError serializableError =
                    new SerializableError { { nameof(registration.Email), "Email already exist in the system" } };
                return this.StatusCode((int)HttpStatusCode.Conflict, serializableError);
            }

            User newUser = new User
            {
                Email = registration.Email,
                UserName = registration.Email,
                Id = registration.Email,

            };
            var result = await _userManager.CreateAsync(newUser, registration.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            user = await _userManager.FindByEmailAsync(registration.Email);
            await _userManager.AddClaimAsync(user,
                new Claim("registration-date", DateTime.UtcNow.ToString("yy-MM-dd")));

            //for testing purposes. do not use in production
            //if (registration.Email.Contains("admin"))
            //{

            //    await _userManager.AddToRoleAsync(user, "Admin");
            //}
            //

            return Ok();

        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<TokenDTO>> Login([FromBody] LoginUserDTO model)
        {
            if (model == null) return new StatusCodeResult(500);

            if (model.grant_type == "password")
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.username, model.password,
                    isPersistent: false, lockoutOnFailure: false);
                if (!result.Succeeded)
                {
                    return Unauthorized();
                }

                User user = await _userManager.FindByEmailAsync(model.username);

                // username & password matches: create and return the refresh token.

                Token newToken = new Token() { ClientId = model.client_id, CreatedDate = DateTime.UtcNow, Type = 0, UserId = user.Id, Value = Guid.NewGuid().ToString("N") };
                _context.Tokens.Add(newToken);
                _context.SaveChanges();

                // create and return the access token

                TokenDTO nToken = await GenerateTokenAsync(user, newToken.Value);
                return nToken;

            }
            if (model.grant_type == "refresh_token")
            {
                var rt = _context.Tokens.FirstOrDefault(t => t.ClientId == model.client_id && t.Value == model.refresh_token);

                if (rt == null)
                {
                    // refresh token not found of invalid (or invalid clientId)
                    return new UnauthorizedResult();
                }
                //check if there's a user with the refresh token's userId
                var user = await _userManager.FindByIdAsync(rt.UserId);

                if (user == null)
                {
                    //userid not found of invalid
                    return new UnauthorizedResult();
                }

                Token newToken = new Token() { ClientId = model.client_id, CreatedDate = DateTime.UtcNow, Type = 0, UserId = user.Id, Value = Guid.NewGuid().ToString("N") };

                //invalidate the old refresh token (by deleting it)
                _context.Tokens.Remove(rt);
                //add the new refresh token
                _context.Tokens.Add(newToken);
                _context.SaveChanges();

                TokenDTO nToken = await GenerateTokenAsync(user, newToken.Value);
                return nToken;
            }

            return new UnauthorizedResult();
        }

        private async Task<TokenDTO> GenerateTokenAsync(User user, string refreshToken)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var userClaims = await _userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var expirationMins = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationMins");
            var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));
            var token = new JwtSecurityToken
            (
                issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(expirationMins)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey),
                    SecurityAlgorithms.HmacSha256)
            );

            string serializedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return new TokenDTO()
            {
                token = serializedToken,
                expiration = expirationMins,
                refresh_token = refreshToken
            };
           
        }

        [Authorize]
        [HttpGet("Email")]
        public ActionResult<string> GetEmail()
        {
            return User.Identity.Name;
        }

        [AllowAnonymous]
        [HttpGet("MyAPIs")]
        public ActionResult<string> MyAPIs()
        {
             return "Welcome to my APIs";
        }

        [AllowAnonymous]
        [HttpGet("error")]
        public ActionResult ThrowError()
        {
            throw new InvalidOperationException("This is an example of unhandled exception");
        }
    }
}