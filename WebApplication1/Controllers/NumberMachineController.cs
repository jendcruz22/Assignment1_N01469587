using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method performs 4 arithmetic operations on a given number i.e division, subtraction, multiplication, addition
        /// <example>GET api/numbermachine/-20 -> 420</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Final value calculated after arithmetic operations</returns>
        public decimal Get(decimal id)
        {
            decimal operation1 = id/2;
            decimal operation2 = operation1 - 10;
            decimal operation3 = operation2 * operation2;
            decimal operation4 = operation3 + 20;
            return operation4;
        }
    }
}
