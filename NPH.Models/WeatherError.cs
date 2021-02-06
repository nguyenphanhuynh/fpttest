using Newtonsoft.Json;

namespace NPH.Models
{
    public class WeatherError
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }
}
