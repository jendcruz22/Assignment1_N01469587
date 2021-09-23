using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class FortNightController : ApiController
    {
        public string Get(string id)
        {
            // Calculate number of fortnights
            double fortnights = (Int32.Parse(id) / 14)+1;

            // Calculate cost of stay with respect to number of fortights
            double costPerNight = Math.Round((fortnights * 5.50),2);

            // Calculate Tax Amount
            double taxAmount = Math.Round((costPerNight * 0.13),2);

            // Calculate Total Amount
            double totalAmount = Math.Round((taxAmount + costPerNight),2);

            // Print output
            string output = fortnights + " fortnights at $5.50/FN = $" + costPerNight + "CAD \n HST 13% = $" + taxAmount + "CAD \n Total = $" + totalAmount + "CAD";
            
            return output;
        }
    }
}
