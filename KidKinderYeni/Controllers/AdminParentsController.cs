using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;

namespace KidKinderYeni.Controllers
{
    public class AdminParentsController : Controller
    {
        // GET: AdminParents
        KidKinderContext context=new KidKinderContext();
        public ActionResult ParentsList()
        {
            var values=context.Parents.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateParents()
        {

            return View();

        }


        [HttpPost]
        public ActionResult CreateParents(Parents parents)
        {
            context.Parents.Add(parents);
            context.SaveChanges();
            return RedirectToAction("ParentsList");
        }



        public ActionResult DeleteParents(int id)
        {
            var value = context.Parents.Find(id);
            context.Parents.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ParentsList");
        }



        [HttpGet]
        public ActionResult UpdateParents(int id)
        {
            List<SelectListItem> values = (from x in context.Parents.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.NameSurname,
                                               Value = x.ParentsId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.Parents.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateParents(Parents parents)
        {
            var value = context.Parents.Find(parents.ParentsId);
            value.NameSurname = parents.NameSurname;
            value.Number = parents.Number;
            context.SaveChanges();
            return RedirectToAction("ParentsList");
        }
    }
}