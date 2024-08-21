using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class Communication
    {
        public int CommunicationId { get; set; }
        public string Description { get; set; }
        public string Addres { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}