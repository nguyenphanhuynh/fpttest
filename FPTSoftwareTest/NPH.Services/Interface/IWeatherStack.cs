using NPH.Models;

namespace NPH.Services.Interface
{
    public interface IWeatherStack
    {
        public WeatherResult Execute(string serviceUrl, int zipCode);
    }
}
