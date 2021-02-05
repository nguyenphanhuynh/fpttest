using Newtonsoft.Json;
using System;

namespace NPH.Models
{
    public class WeatherLocaltion
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("long")]
        public float Longitude { get; set; }

        [JsonProperty("timezone_id")]
        public string TimezoneId { get; set; }

        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }

        [JsonProperty("localtime_epoch")]
        public int LocalTime_Epoch { get; set; }

        [JsonProperty("utc_offset")]
        public float UtcOffset { get; set; }
    }
}
