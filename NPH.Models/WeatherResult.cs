using Newtonsoft.Json;

namespace NPH.Models
{
    public class WeatherResult
    {
        [JsonProperty("success")]
        public virtual bool Success { get; set; }

        [JsonProperty("request")]
        public virtual  WeatherRequest Request { get; set; }

        [JsonProperty("location")]
        public virtual WeatherLocaltion Location { get; set; }

        [JsonProperty("current")]
        public virtual WeatherCurrent Current { get; set; }

        [JsonProperty("error")]
        public virtual WeatherError Error { get; set; }
    }
}
