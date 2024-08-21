using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class BookHeader
    {
        public int BookHeaderId { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}