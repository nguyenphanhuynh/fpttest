using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPH.Models
{
    public class WeatherCurrent
    {
        [JsonProperty("observation_time")]
        public virtual string ObservationTime { get; set; }

        [JsonProperty("temperature")]
        public virtual float Temperature { get; set; }

        [JsonProperty("weather_code")]
        public virtual int WeatherCode { get; set; }

        [JsonProperty("weather_icons")]
        public virtual List<string> WeatherIcons { get; set; }

        [JsonProperty("weather_descriptions")]
        public virtual List<string> WeatherDescriptions { get; set; }

        [JsonProperty("wind_speed")]
        public virtual float WindSpeed { get; set; }

        [JsonProperty("wind_degree")]
        public virtual float WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public virtual string WindDir { get; set; }

        [JsonProperty("pressure")]
        public virtual float Pressure { get; set; }

        [JsonProperty("precip")]
        public virtual float Precip { get; set; }

        [JsonProperty("humidity")]
        public virtual float Humidity { get; set; }

        [JsonProperty("cloudcover")]
        public virtual float CloudCover { get; set; }

        [JsonProperty("feelslike")]
        public virtual float FeelsLike { get; set; }

        [JsonProperty("uv_index")]
        public virtual float UvIndex { get; set; }

        [JsonProperty("visibility")]
        public virtual float Visibility { get; set; }

        [JsonProperty("is_day")]
        public virtual string IsDay { get; set; }
    }
}
