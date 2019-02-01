using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using POS.APIs.Data;
using POS.APIs.Data.Models;
using POS.APIs.Infrastructure.APIErrors;


namespace POS.APIs
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
                config.Filters.Add<GlobalExceptionFilter>();
            });

            services.AddDbContext<GLPOSContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GLPOSDB")));

            services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<GLPOSContext>()
               .AddDefaultTokenProviders();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(jwtOptions =>
                {
                    jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateActor = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["JWTConfiguration:Issuer"],
                        ValidAudience = Configuration["JWTConfiguration:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTConfiguration:SigningKey"]))

                    };
                });

            // Creating an authorization policy example

            //services.AddAuthorization(options => options.AddPolicy("ExperiencedUser", (AuthorizationPolicyBuilder policy) => policy.RequireAssertion(context => 
            //{
            //    var registrationClaimValue = context.User.Claims.SingleOrDefault(c => c.Type == "registration-date")?.Value;
            //    if (DateTime.TryParseExact(registrationClaimValue, "yy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out var registrationTime))
            //    {
            //        return registrationTime.AddYears(1) < DateTime.UtcNow;
            //    }
            //    return false;
            //})));

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            app.UseDefaultFiles();

            app.UseCors(b =>
            {
                b.AllowAnyHeader();
                b.AllowAnyOrigin();
                b.AllowAnyMethod();
            });

            FileExtensionContentTypeProvider provider = new FileExtensionContentTypeProvider();

            provider.Mappings[".ts"] = "application/x-typescript";
            StaticFileOptions staticFileOptions = new StaticFileOptions()
            {
                ContentTypeProvider = provider
            };

            app.UseStaticFiles(staticFileOptions);

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes
                    .MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}")
                    .MapRoute(name: "api", template: "api/{controller}/{action}/{id?}");
                    //.MapRoute(name: "api", template: "api/{controller=Account}/{action=MyAPIs}/{id:int?}");
            });
        }
    }
}
