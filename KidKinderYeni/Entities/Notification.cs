﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime NotificationDate { get; set; }
    }
}