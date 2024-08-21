using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Entities;
using KidKinderYeni.Context;

namespace KidKinderYeni.Controllers
{
    public class AdminStudentController : Controller
    {
        // GET: AdminStudent
        KidKinderContext context=new KidKinderContext();
        public ActionResult StudentList()
        {
            var values=context.Students.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateStudent()
        {

            return View();

        }


        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }



        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }



        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            List<SelectListItem> values = (from x in context.Students.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.NameSurname,
                                               Value = x.StudentId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.Students.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            var value = context.Students.Find(student.StudentId);
            value.StudentClass =student.StudentClass;
            value.NameSurname =student.NameSurname;
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
    }
}