using NPH.Models;
using NPH.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPH.Services.Interface
{
    public class WeatherAnalysis : IWeatherAnalysis
    {
        public bool FlyKite(WeatherResult weatherResult)
        {
            return GoOuside(weatherResult) && weatherResult.Current.WindSpeed > 15;
        }

        public bool GoOuside(WeatherResult weatherResult)
        {
            return weatherResult.Current?.WeatherCode < 263;
        }

        public bool WearSunscreen(WeatherResult weatherResult)
        {
            return weatherResult.Current.UvIndex > 3;
        }
    }
}
