using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs.Models
{
    class ForecastLastStatus
    {

        public ForecastLastStatus()
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
