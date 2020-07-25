using Newtonsoft.Json;
using System;
using WallhavenGallery.Models.Enums;

namespace WallhavenGallery.Converters
{
    internal class PurityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Purity) || t == typeof(Purity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "sfw":
                    return Purity.Sfw;
                case "sketchy":
                    return Purity.Sketchy;
            }
            throw new Exception("Cannot unmarshal type Purity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Purity)untypedValue;
            switch (value)
            {
                case Purity.Sfw:
                    serializer.Serialize(writer, "sfw");
                    return;
                case Purity.Sketchy:
                    serializer.Serialize(writer, "sketchy");
                    return;
            }
            throw new Exception("Cannot marshal type Purity");
        }

        public static readonly PurityConverter Singleton = new PurityConverter();
    }
}
