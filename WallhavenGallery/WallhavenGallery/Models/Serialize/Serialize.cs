using Newtonsoft.Json;
using WallhavenGallery.Converters;

namespace WallhavenGallery.Models.Serialize
{
    public static class Serialize
    {
        public static string ToJson(this ResponseModel self) 
            => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
