using NPH.Models;

namespace NPH.Services.Implementation
{
    public interface IWeatherAnalysis
    {
        public bool GoOuside(WeatherResult weatherResult);
        public bool WearSunscreen(WeatherResult weatherResult);
        public bool FlyKite(WeatherResult weatherResult);
    }
}
