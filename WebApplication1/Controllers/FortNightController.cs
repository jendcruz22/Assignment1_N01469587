using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class FortNightController : ApiController
    {
        /// <summary>
        /// Calculate hosting cost for a customer's stay depending on the duration of their stay.
        /// </summary>
        /// <example>GET api/fortnight/14 -> "2 fortnights at $5.50/FN = $11.00 CAD”
        ///                                 “HST 13% = $1.43 CAD”
        ///                                 “Total = $12.43 CAD” </example>
        /// 
        /// <param name="id"></param>
        /// <returns>The total cost of hosting based on duration of stay (per fortnight) after tax.</returns>
        public IEnumerable<string> Get(string id)
        {
            // Calculate number of fortnights
            decimal fortnights = (Int32.Parse(id) / 14)+1;

            // Calculate cost of stay with respect to number of fortights
            decimal costPerNight = Math.Round(Decimal.Multiply(fortnights, (decimal)5.50),2);

            // Calculate Tax Amount
            decimal taxAmount = Math.Round(Decimal.Multiply(costPerNight, (decimal)0.13),2);

            // Calculate Total Amount
            decimal totalAmount = Math.Round((taxAmount + costPerNight),2);

            // Culture property changed to US
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

            // Print output
            string costPerFortNight = fortnights + " fortnights at $5.50/FN = " + string.Format("{0:C}", costPerNight) + "CAD";
            string totalTax = "HST 13% = " + string.Format("{0:C}", taxAmount) + "CAD";
            string finalAmount = "Total = " + string.Format("{0:C}", totalAmount) + "CAD";

            return new string[] { costPerFortNight, totalTax, finalAmount };

        }
    }
}
