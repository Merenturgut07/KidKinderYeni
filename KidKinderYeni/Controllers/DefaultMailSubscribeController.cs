using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class DefaultMailSubscribeController : Controller
    {
		// GET: DefaultMailSubscribe
		KidKinderContext context = new KidKinderContext();
		public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MailSub()
        {
            return View();
        }
		[HttpGet]
		public ActionResult MailSub(MailSubscribe ms)
		{
			context.MailSubscribes.Add(ms);
			context.SaveChanges();
			return RedirectToAction("Contact", "Index");

		}


	}
}