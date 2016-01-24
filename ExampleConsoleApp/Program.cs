using MgmWeatherForecast;
using MgmWeatherForecast.Models;
using MgmWeatherForecast.PlacesModels;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace SampleWeatherConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPlace place = new City("ISTANBUL");
            var forecast = WeatherForecast.GetForecastAsync(place).Result;
            Console.WriteLine("Current temperature: " + forecast.CurrentForecast.Temperature);
        }
    }
}
