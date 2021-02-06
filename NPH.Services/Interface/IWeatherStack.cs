using NPH.Models;

namespace NPH.Services.Interface
{
    public interface IWeatherStack
    {
        public WeatherResult GetWeatherInformation(string serviceUrl, int zipCode);
    }
}
