using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;
using Microsoft.Ajax.Utilities;

namespace KidKinderYeni.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }

        public PartialViewResult GalleryHeaderPartial()
        {
            return PartialView();
        }
    }
}