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
        [HttpGet]
        public string Get(string id)
        {
            return id;
        }

        [HttpPost]
        public string Post()
        {
            return "Hello World";
        }
    }
    
    
        
}
