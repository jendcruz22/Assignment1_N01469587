using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 to a given integer value
        /// <example>GET api/AddTen/20 -> 30</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Round value with ten added to the input</returns>
        public int Get(int id)
        {
            int addedValue = id + 10;
            return addedValue;
        }
    }
}
