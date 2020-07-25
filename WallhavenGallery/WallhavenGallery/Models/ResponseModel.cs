using Newtonsoft.Json;
using WallhavenGallery.Converters;

namespace WallhavenGallery.Models
{
    public class ResponseModel
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
  
        public static ResponseModel FromJson(string json) => JsonConvert.DeserializeObject<ResponseModel>(json, Converter.Settings);
    }    
}
