using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace POS.APIs.Data.Models
{
    public class User : IdentityUser
    {
        public virtual List<Token> Tokens { get; set; }
    }
}
