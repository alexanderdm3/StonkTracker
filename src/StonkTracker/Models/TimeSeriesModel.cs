﻿using Newtonsoft.Json;

namespace StonkTracker.Models
{
    public class TimeSeriesModel
    {
        [JsonProperty(PropertyName = "1. open")]
        public string Open { get; set; }
        [JsonProperty(PropertyName = "2. high")]
        public string High { get; set; }
        [JsonProperty(PropertyName = "3. low")]
        public string Low { get; set; }
        [JsonProperty(PropertyName = "4. close")]
        public string Close { get; set; }
        [JsonProperty(PropertyName = "5. volume")]
        public string Volume { get; set; }
    }
}
