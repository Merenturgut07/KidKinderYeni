using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string ImageUrl { get; set; }
        public bool Durum { get; set; }
    }
}