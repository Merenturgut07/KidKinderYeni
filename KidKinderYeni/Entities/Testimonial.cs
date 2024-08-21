using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Iamgeurl { get; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
    }
}