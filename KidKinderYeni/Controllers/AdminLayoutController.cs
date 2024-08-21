using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;
namespace KidKinderYeni.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialPreLoader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNotifation()
        {
            var values=context.Notifications.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialNavbarProfileHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeaderAdmin()
        {
            return PartialView();
        }

    }
}