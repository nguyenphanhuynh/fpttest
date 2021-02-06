using Newtonsoft.Json;
using System;

namespace NPH.Models
{
    public class WeatherLocaltion
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("country")]
        public virtual string Country { get; set; }

        [JsonProperty("region")]
        public virtual string Region { get; set; }

        [JsonProperty("lat")]
        public virtual float Latitude { get; set; }

        [JsonProperty("long")]
        public virtual float Longitude { get; set; }

        [JsonProperty("timezone_id")]
        public virtual string TimezoneId { get; set; }

        [JsonProperty("localtime")]
        public virtual DateTime LocalTime { get; set; }

        [JsonProperty("localtime_epoch")]
        public virtual int LocalTime_Epoch { get; set; }

        [JsonProperty("utc_offset")]
        public virtual float UtcOffset { get; set; }
    }
}
