using Newtonsoft.Json;
using WallhavenGallery.Converters;

namespace WallhavenGallery.Models
{
    public class Meta
    {
        [JsonProperty("current_page")]
        public long CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public long LastPage { get; set; }

        [JsonProperty("per_page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("query")]
        public object Query { get; set; }

        [JsonProperty("seed")]
        public object Seed { get; set; }
    }
}
