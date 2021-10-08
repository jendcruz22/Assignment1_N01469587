using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Returns the square of a given number provided by the user.
    /// <example>GET api/Square/2 -> 4</example>
    /// </summary>
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            int squaredValue = id * id;
            return squaredValue;
        }
    }
}
