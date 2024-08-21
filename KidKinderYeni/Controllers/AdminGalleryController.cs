using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;

namespace KidKinderYeni.Controllers
{
    public class AdminGalleryController : Controller
    {
        // GET: AdminGallery
        KidKinderContext context=new KidKinderContext();

        public ActionResult GalleryListIndex()
        {
            var values = context.Galleries.ToList();
            return View(values);
        }
        public ActionResult GalleryList()
        {
            var values=context.Galleries.Where(x => x.Durum == true).ToList();
            return View(values);
        }
        public ActionResult AdminGalleryDelete(int id)
        {
            var values = context.Galleries.Find(id);
            values.Durum = false;
            context.SaveChanges();
            return RedirectToAction("AdminGalleryList");
        }
    }
}