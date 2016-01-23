using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs.Models
{
    class ForecastDaily
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
