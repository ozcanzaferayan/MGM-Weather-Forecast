namespace MgmUtils.Models
{
    public class ForecastDailyHistory
    {
        public ForecastDailyHistory()
        {
            Extremity = new Temperature();
            Average = new Temperature();
        }
        public Temperature Extremity { get; set; }
        public Temperature Average { get; set; }
    }
}
