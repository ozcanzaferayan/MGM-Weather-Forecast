﻿using MgmUtils.cs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MgmService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WeatherService : IWeatherService
    {
        public async Task<string> GetCurrentWeatherAsync()
        {
            WebRequest req = WebRequest.Create("http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?m=ISTANBUL");
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
    }
}
