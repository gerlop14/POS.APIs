using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.APIs.Infrastructure.APIErrors
{
    public class ErrorDetails : ValidationProblemDetails
    {
        public Exception Exception { get; set; }
    }
}
