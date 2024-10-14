using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using JwelleryShop.DAL;
using JwelleryShop.Models;

namespace JwelleryShop.Controllers
{
    public class SignUpController : Controller
    {
        signupEntities entity=new signupEntities();
        // GET: SignUp
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel credentials)
        {
            bool userExist = entity.signs.Any(x=>x.Email == credentials.Email && x.Password==credentials.Password);
            sign u=entity.signs.FirstOrDefault(x => x.Email == credentials.Email && x.Password == credentials.Password);
            if (userExist)
            {
                FormsAuthentication.SetAuthCookie(u.Name, false);
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("", "Username or Password is wrong");

            return View();
        }
        [HttpPost]
        public ActionResult Signup(sign userinfo)
        {
            entity.signs.Add(userinfo);
            entity.SaveChanges();
            return RedirectToAction("Login");
            return View();
        }
        public ActionResult Signout()
        {
            return View();
        }
    }
}