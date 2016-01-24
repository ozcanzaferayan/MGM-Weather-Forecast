using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmWeatherForecast.PlacesModels
{
    public abstract class AbstractPlace
    {
        protected AbstractPlace(string name)
        {
            Name = name;
        }
        protected AbstractPlace() { }
        public string Name { get; set; }
    }
}
