using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class AdminContactController : Controller
    {
		// GET: AdminContact
		KidKinderContext context = new KidKinderContext();
		public ActionResult Index()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }


		[HttpGet]
		public ActionResult ContactEkle()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ContactEkle(Contact c)
		{
			c.SendDate = DateTime.Now;
			c.Isread = true;
			context.Contacts.Add(c);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult ContactSil(int id)
		{
			var values = context.Contacts.Find(id);
			context.Contacts.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}