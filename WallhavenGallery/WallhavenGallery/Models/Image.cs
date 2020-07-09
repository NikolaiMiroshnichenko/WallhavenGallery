using System;
using System.Collections.Generic;
using System.Text;

namespace WallhavenGallery.Models
{
    public class Image : Entity
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
