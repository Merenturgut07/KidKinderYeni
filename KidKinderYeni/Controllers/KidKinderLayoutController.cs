using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Models;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;

namespace KidKinderYeni.Controllers
{
    public class KidKinderLayoutController : Controller
    {
        // GET: KidKinderLayout
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

        public PartialViewResult PartialFooter()
        {
            var values = context.Communications.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}