using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Money
    {
        // Base URL for the API
        const string baseUrl = "http://data.fixer.io/api/";

        /// <summary>
        /// Return the Date
        /// </summary>
        public static string Date { get {
                string url = baseUrl + "latest?access_key=e893e2e8622b73546983d793c7af3643";

                WebClient wc = new WebClient();
                string jsonData = wc.DownloadString(url);
                JObject o = JObject.Parse(jsonData);
                // convert unix time stamp to Coordinated Universal Time (UTC) date and time
                DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeSeconds((long)o["timestamp"]).UtcDateTime;
                return dateTime.ToString();
            }
        }

        /// <summary>
        /// Get a List with all available conversion rates
        /// </summary>
        /// <param name="currency">The Base currency</param>
        /// <returns></returns>
        public static IList<Rate> GetRates(Currency currency)
        {
            string url = baseUrl + "latest?access_key=e893e2e8622b73546983d793c7af3643&base=" + currency.Value;

            //Get the JSON string
            WebClient wc = new WebClient();
            string jsonData = wc.DownloadString(url);
            
            JObject o = JObject.Parse(jsonData);
            JToken rates = o["rates"];          

            IList<Rate> RatesList = new List<Rate>();
            foreach (JProperty item in rates)
            {                
                RatesList.Add(new Rate()
                {
                    CurrencyName = item.Name,
                    Value = (double)item.Value
                });
            }

            return RatesList;
        }

        /// <summary>
        /// Convert a given Value from one Currency to another
        /// </summary>
        /// <param name="Value">Value to convert</param>
        /// <param name="From">Start Currency</param>
        /// <param name="To">Currency to convert to</param>
        /// <returns></returns>
        public static double FromTo(double Value, Currency From, Currency To)
        {
            string url = baseUrl + "latest?access_key=e893e2e8622b73546983d793c7af3643&base=" + From.Value;

            WebClient wc = new WebClient();
            string jsonData = wc.DownloadString(url);

            JObject o = JObject.Parse(jsonData);
            double ChangeRate = (double)o["rates"][To.Value];

            return ChangeRate * Value;
        }
    }
}
