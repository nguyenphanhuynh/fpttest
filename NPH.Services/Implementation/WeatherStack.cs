using Newtonsoft.Json;
using NPH.Models;
using NPH.Services.Interface;
using NPH.Utilities;

namespace NPH.Services.Implementation
{
    public class WeatherStack : IWeatherStack
    {
        public WeatherResult GetWeatherInformation(string serviceUrl, int zipCode)
        {
            string json = new Helpers().Get($"{serviceUrl}{zipCode}");
            return JsonConvert.DeserializeObject<WeatherResult>(json);
        }
    }
}
