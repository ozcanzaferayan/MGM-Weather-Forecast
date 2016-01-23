using ConsoleApplication1.WeatherService;
using MgmUtils.cs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string weatherJson = GetWeather().Result;
            Console.Read();

        }

        public async static Task<String> GetWeather()
        {
            WeatherServiceClient client = new WeatherServiceClient();
            string weatherJson = await client.GetCurrentWeatherAsync();
            return weatherJson;
        }
    }
}
