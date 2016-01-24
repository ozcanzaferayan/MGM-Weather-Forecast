namespace MgmWeatherForecast.Models
{
    public class ForecastCurrent
    {

        public ForecastCurrent()
        {
            this.Wind = new Wind();
        }

        public string Weather { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public Wind Wind { get; set; }
        public string Pressure { get; set; }
        public string Sight { get; set; }
    }
}
