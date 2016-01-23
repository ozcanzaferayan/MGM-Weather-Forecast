using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs
{
    class WeatherRequest
    {
        public const string MGM_URL = "http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?m={{placeName}}";

        public async Task<string> GetForecast(string placeName)
        {
            string url = MGM_URL.Replace("{{placeName}}", "placeName");
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
            return PageParser.Parse(ref responseString);
        }

        public async Task<string>
    }
}
