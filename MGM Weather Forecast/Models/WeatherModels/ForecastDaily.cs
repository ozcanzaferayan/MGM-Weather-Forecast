namespace MgmWeatherForecast.Models
{
    public class ForecastDaily
    {
        public ForecastDaily()
        {
            Temperature = new Temperature();
            Humidity = new Humidity();
            Wind = new Wind();
        }
        public Temperature Temperature { get; set; }
        public string Weather { get; set; }
        public Humidity Humidity { get; set; }
        public Wind Wind { get; set; }
    }
}
