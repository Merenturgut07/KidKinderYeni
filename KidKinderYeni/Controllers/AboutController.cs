using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }
    }
}