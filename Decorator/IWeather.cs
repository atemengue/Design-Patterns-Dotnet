using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IWeather
    {
        CurrentWeather GetCurrentWeather(String location);
        LocationForecast GetLocationForecast(String location);
    }
}
