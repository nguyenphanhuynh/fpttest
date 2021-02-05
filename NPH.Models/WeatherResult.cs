using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPH.Models
{
    public class WeatherResult
    {
        [JsonProperty("request")]
        public WeatherRequest WeatherRequest { get; set; }

        [JsonProperty("location")]
        public WeatherLocaltion WeatherLocation { get; set; }

        [JsonProperty("current")]
        public WeatherCurrent WeatherCurrent { get; set; }
    }
}
