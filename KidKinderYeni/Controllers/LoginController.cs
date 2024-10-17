using KidKinderYeni.Context;
using KidKinderYeni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace KidKinderYeni.Controllers
{

    public class LoginController : Controller
    {
        KidKinderContext context = new KidKinderContext();


        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if(result != null)
            {
                FormsAuthentication.SetAuthCookie(admin.UserName,true);
                Session["username"]=result.UserName;
                return RedirectToAction("TeacherList", "AdminTeacher");
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
			return RedirectToAction("AdminLogin", "Login");

		}
    }
}