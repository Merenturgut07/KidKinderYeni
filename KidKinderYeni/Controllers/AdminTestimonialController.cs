using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinderYeni.Context;
using KidKinderYeni.Entities;
namespace KidKinderYeni.Controllers
{
    public class AdminTestimonialController : Controller
    {
        // GET: AdminTestimonial
        KidKinderContext context=new KidKinderContext();
        public ActionResult TestimonialList()
        {
            var values=context.Testimonials.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateTestimonial()
        {

            return View();

        }


        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }


        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }



        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            List<SelectListItem> values = (from x in context.Testimonials.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.TestimonialId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.Testimonials.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = context.Testimonials.Find(testimonial.TestimonialId);
            value.Iamgeurl = testimonial.Iamgeurl;
            value.NameSurname = testimonial.NameSurname;
            value.Title = testimonial.Title;
            value.Comment = testimonial.Comment;
            value.Description = testimonial.Description;
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }




    }
}