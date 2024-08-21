using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;

namespace KidKinderYeni.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature() 
        {
            var values=context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values=context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values=context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialClassRooms()
        {
            var values=context.ClassRooms.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookASeat()
        {
            var values=context.BookASeats.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTeacher()
        {
            var values=context.Teachers.Take(4).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values=context.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            var values=context.Communications.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialAboutList()
        {
            var values=context.AboutLists.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBookHeader()
        {
            var values=context.BookHeaders.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBookASeatList()
        {
            var values= context.BookASeatLists.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMailSubscribe()
        {
            var values=context.MailSubscribes.ToList();
            return PartialView(values);
        }
    }
}