using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace Azure_NETCORE_Example.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            string token = "";
            if (Request.Headers.TryGetValue("User-Token", out StringValues headerValue))
            {
                token = headerValue.ToString();
            }
            return token;
        }
    }
}
