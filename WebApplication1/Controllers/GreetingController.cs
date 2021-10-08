using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Get method for displaying a greeting provided by the user.
        /// <example>GET api/Greeting/hello -> hello</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The string of text as inputed by the user</returns>
        [HttpGet]
        public string Get(string id)
        {
            return id;
        }

        /// <summary>
        /// Simply prints the string returned by the post method. 
        /// <example>GET curl -d "" api/Greeting -> Hello World</example>
        /// </summary>
        /// <returns>The string mentioned in the return statement</returns>
        [HttpPost]
        public string Post()
        {
            return "Hello World";
        }
    }
    
    
        
}
