using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            //BranchIdsi Resim Öğretmeni Olan Öğretmen Sayısı

            ViewBag.ResimOgretmeniCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.Name == "Resim Öğretmeni").Select(y => y.BranchId).FirstOrDefault()).Count();



            //Ortalama Sınıf Fiyatları

            ViewBag.AvgPrice = context.ClassRooms.Average(c => c.Price).ToString("0.00");

            //sınıf sayısı
            ViewBag.ClassRoomCount = context.ClassRooms.Count();
            //mesaj sayısı
            ViewBag.MessagesCount = context.Notifications.Count();

            //2.kısım

            //hizmet sayısı
            ViewBag.StudentCount = context.Students.Count();

            //Veli Sayısı
            ViewBag.ParentsCount = context.Parents.Count();

            //gelen mesaj sayısı
            ViewBag.TeacherCount = context.Teachers.Count();

            //Matematik 
            ViewBag.MatematikCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(s => s.Name == "Matematik").Select(y => y.BranchId).FirstOrDefault()).Count();

            //hizmet sayısı
            ViewBag.TestimonialCount = context.Testimonials.Count();

            //Fotoğraf Sayısı
            ViewBag.GalleyCount = context.Galleries.Count();


            ViewBag.chart1 = context.Students.Where(x => x.StudentId == 1).Count().ToString();
            ViewBag.chart2 = context.Students.Where(x => x.StudentId == 2).Count().ToString();
            ViewBag.chart3 = context.Students.Where(x => x.StudentId == 4).Count().ToString();
            ViewBag.chart4 = context.Students.Where(x => x.StudentId == 5).Count().ToString();
            ViewBag.chart5 = context.Students.Where(x => x.StudentId == 6).Count().ToString();
            ViewBag.chart6 = context.Students.Where(x => x.StudentId == 7).Count().ToString();
            ViewBag.chart7 = context.Students.Where(x => x.StudentId == 8).Count().ToString();
            ViewBag.chart8 = context.Students.Where(x => x.StudentId == 9).Count().ToString();

            return View();
        }

    }
}