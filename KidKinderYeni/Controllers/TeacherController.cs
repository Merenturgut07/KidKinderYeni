using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult PatrialMoreTeacher()
        {
            var values = context.Teachers.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialHeaderTeacher()
        {
            return PartialView();
        }

    }
}