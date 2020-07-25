using Newtonsoft.Json;
using System;

namespace WallhavenGallery.Models
{
    public class Thumbs
    {
        [JsonProperty("large")]
        public Uri Large { get; set; }

        [JsonProperty("original")]
        public Uri Original { get; set; }

        [JsonProperty("small")]
        public Uri Small { get; set; }
    }
}
