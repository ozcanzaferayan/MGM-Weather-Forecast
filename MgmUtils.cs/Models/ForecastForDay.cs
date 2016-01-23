using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs.Models
{
    class ForecastForDay
    {
        public ForecastForDay()
        {
            Daily = new ForecastDaily();
            History = new ForecastDailyHistory();
        }
        public string Date { get; set; }
        public ForecastDaily Daily { get; set; }
        public ForecastDailyHistory History { get; set; }
    }
}
