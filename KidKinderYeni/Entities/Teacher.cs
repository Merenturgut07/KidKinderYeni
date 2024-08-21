using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}