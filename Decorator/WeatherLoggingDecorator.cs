using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WeatherLoggingDecorator : IWeather
    {
        private IWeather _weather;
        private WeatherLoggingDecorator _logger;

        public WeatherLoggingDecorator(IWeather weather, WeatherLoggingDecorator logger)
        {
            _weather = weather;
            _logger = logger;   
        }
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
