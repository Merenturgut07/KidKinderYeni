using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderYeni.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Boş Geçmeyiniz")]
        [StringLength(30,ErrorMessage ="Lütfen En Fazla 30 Karakter Veri Girişi Yapınız ")]
        public string NameSurname { get; set; }


        [Required(ErrorMessage = "Lütfen E mail Kısmını Boş Geçmeyiniz")]
        [StringLength(50, ErrorMessage = "Lütfen En Fazla 50 Karakter Veri Girişi Yapınız ")]
        [EmailAddress(ErrorMessage ="Lütfen Geçerli Mail Adresi Giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen Konu Kısmını Boş Geçmeyiniz")]
        [StringLength(50, ErrorMessage = "Lütfen En Fazla 50 Karakter Veri Girişi Yapınız ")]
        [MinLength(5,ErrorMessage ="Lütfen En Az 5 Karekterli Veri Girişi Yapınız")]
        public string Subject { get; set; }



        [Required(ErrorMessage = "Lütfen Mesaj Kısmını Boş Geçmeyiniz")]
        [StringLength(1000, ErrorMessage = "Lütfen Daha Az Karakter Veri Girişi Yapınız ")]
        public string Message { get; set; }
    }
}