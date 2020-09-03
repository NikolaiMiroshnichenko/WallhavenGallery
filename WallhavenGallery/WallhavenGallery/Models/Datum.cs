﻿using Newtonsoft.Json;
using System;
using WallhavenGallery.Models.Enums;

namespace WallhavenGallery.Models
{
    public class Datum
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("short_url")]
        public Uri ShortUrl { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("favorites")]
        public long Favorites { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("purity")]
        public Purity Purity { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("dimension_x")]
        public long DimensionX { get; set; }

        [JsonProperty("dimension_y")]
        public long DimensionY { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("file_size")]
        public long FileSize { get; set; }

        [JsonProperty("file_type")]
        public FileType FileType { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("path")]
        public Uri Path { get; set; }

        [JsonProperty("thumbs")]
        public Thumbs Thumbs { get; set; }
    }
}