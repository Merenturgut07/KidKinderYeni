using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;
using System.Web.Configuration;

namespace KidKinderYeni.Controllers
{
	public class ContactController : Controller
	{
		// GET: Contact
		KidKinderContext context = new KidKinderContext();
		public ActionResult Index()
		{
			return View();
		}
		public PartialViewResult ContactHeaderPartial()
		{
			return PartialView();
		}
		public PartialViewResult ContactAddressPartial()
		{
			ViewBag.description = context.Communications.Select(x => x.Description).FirstOrDefault();
			ViewBag.phone = context.Communications.Select(x => x.Phone).FirstOrDefault();
			ViewBag.addres = context.Communications.Select(x => x.Addres).FirstOrDefault();
			ViewBag.Email = context.Communications.Select(x => x.Email).FirstOrDefault();
			return PartialView();
		}

		public PartialViewResult ContactPartial()
		{
			return PartialView();
		}

	}
}

