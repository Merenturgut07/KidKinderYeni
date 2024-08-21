using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;

namespace KidKinderYeni.Controllers
{
    public class AdminGelenMesajController : Controller
    {
        // GET: AdminGelenMesaj
        KidKinderContext context=new KidKinderContext();
        public ActionResult MesajList()
        {
            var values=context.Notifications.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateGelenMesaj()
        {

            return View();

        }

        [HttpPost]
        public ActionResult CreateGelenMesaj(Notification notification)
        {
            context.Notifications.Add(notification);
            context.SaveChanges();
            return RedirectToAction("MesajList");
        }


        public ActionResult DeleteGelenMesaj(int id)
        {
            var value = context.Notifications.Find(id);
            context.Notifications.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MesajList");
        }


        [HttpGet]
        public ActionResult UpdateGelenMesaj(int id)
        {
            List<SelectListItem> values = (from x in context.Notifications.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.NotificationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.Notifications.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateGelenMesaj(Notification notification)
        {
            var value = context.Notifications.Find(notification.NotificationId);
            value.Title = notification.Title;
            value.ImageUrl = notification.ImageUrl;
            value.NotificationDate = notification.NotificationDate;
            value.Description = notification.Description;
            context.SaveChanges();
            return RedirectToAction("MesajList");
        }
    }
}