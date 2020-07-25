using Newtonsoft.Json;
using System;
using WallhavenGallery.Models.Enums;

namespace WallhavenGallery.Converters
{
    internal class FileTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FileType) || t == typeof(FileType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "image/jpeg":
                    return FileType.ImageJpeg;
                case "image/png":
                    return FileType.ImagePng;
            }
            throw new Exception("Cannot unmarshal type FileType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FileType)untypedValue;
            switch (value)
            {
                case FileType.ImageJpeg:
                    serializer.Serialize(writer, "image/jpeg");
                    return;
                case FileType.ImagePng:
                    serializer.Serialize(writer, "image/png");
                    return;
            }
            throw new Exception("Cannot marshal type FileType");
        }

        public static readonly FileTypeConverter Singleton = new FileTypeConverter();
    }
}
