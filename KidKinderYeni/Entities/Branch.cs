using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}