using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Weather : IWeather
    {
        public CurrentWeather GetCurrentWeather(string location)
        {
            throw new NotImplementedException();
        }

        public LocationForecast GetLocationForecast(string location)
        {
            throw new NotImplementedException();
        }
    }
}
