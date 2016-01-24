using MgmWeatherForecast.Models;
using MgmWeatherForecast.PlacesModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MgmWeatherForecast
{
    public class WeatherRequest
    {
        /// <summary>
        /// MGM request url.
        /// </summary>
        public const string MGM_URL_BASE = "http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx";

        /// <summary>
        /// Gets the page asynchronous.
        /// </summary>
        /// <param name="uppercasePlaceName">Name of the place.</param>
        /// <returns></returns>
        private static async Task<string> GetPageAsync(string uppercasePlaceName)
        {
            string url = MGM_URL_BASE + "?m=" + uppercasePlaceName;
            WebRequest req = WebRequest.Create(url);
            WebResponse response = await req.GetResponseAsync();
            var responseString = "";
            using (var stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            return responseString;
        }

        /// <summary>
        /// Gets the forecast asynchronous.
        /// </summary>
        /// <param name="uppercasePlaceName">Name of the place such as ISTANBUL</param>
        /// <returns></returns>
        public static async Task<Forecast> GetForecastAsync(string uppercasePlaceName)
        {
            var responseString = await GetPageAsync(uppercasePlaceName);
            return WeatherParser.Parse(ref responseString);
        }

        /// <summary>
        /// Gets the places asynchronous.
        /// </summary>
        /// <param name="uppercasePlaceName">Name of the uppercase place.</param>
        /// <returns></returns>
        public static async Task<Places> GetPlacesAsync(string uppercasePlaceName)
        {
            var responseString = await GetPageAsync(uppercasePlaceName);
            return PlacesParser.Parse(ref responseString);
        }
    }
}
