﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AgeOfKids { get; set; }
        public string TotalSet { get; set; }
        public string ClassTime { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}