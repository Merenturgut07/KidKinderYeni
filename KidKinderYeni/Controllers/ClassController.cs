using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ClassHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult Class3Partial()
        {
            var values=context.ClassRooms.ToList();
            return PartialView(values);
        }
    }
}