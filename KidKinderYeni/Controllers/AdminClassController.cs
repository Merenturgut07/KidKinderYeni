using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;

namespace KidKinderYeni.Controllers
{
    public class AdminClassController : Controller
    {
        // GET: AdminClass
        KidKinderContext context=new KidKinderContext();
        public ActionResult ClassList()
        {
            var values=context.ClassRooms.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateClass()
        {

            return View();

        }


        [HttpPost]
        public ActionResult CreateClass(ClassRoom classRoom)
        {
            context.ClassRooms.Add(classRoom);
            context.SaveChanges();
            return RedirectToAction("ClassList");
        }


        public ActionResult DeleteClass(int id)
        {
            var value = context.ClassRooms.Find(id);
            context.ClassRooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ClassList");
        }



        [HttpGet]
        public ActionResult UpdateClass(int id)
        {
            List<SelectListItem> values = (from x in context.ClassRooms.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ClassRoomId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.ClassRooms.Find(id);
            return View(value);
            //return View();
        }


        [HttpPost]
        public ActionResult UpdateClass(ClassRoom classRoom)
        {
            var value = context.ClassRooms.Find(classRoom.ClassRoomId);
            value.Title =classRoom.Title;
            value.Description =classRoom.Description;
            value.AgeOfKids =classRoom.AgeOfKids;
            value.TotalSet =classRoom.TotalSet;
            value.ClassTime =classRoom.ClassTime;
            value.Price =classRoom.Price;
            value.ImageUrl = classRoom.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("ClassList");
        }
    }
}