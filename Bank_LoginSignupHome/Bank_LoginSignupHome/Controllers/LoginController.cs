using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bank_LoginSignupHome.Data;
using Bank_LoginSignupHome.Models;
using System.Configuration;

namespace Bank_LoginSignupHome.Controllers
{
    public class LoginController : Controller
    {
        UserContext db = new UserContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel u)
        {
            if(ModelState.IsValid)
            {
                var user = db.Users.Where(model => model.Email == u.Email && model.Password == u.Password).FirstOrDefault();

                if (user != null)
                {
                    Session["userid"] = user.Id;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.Clear();
                    ViewBag.Login = "<script> alert('No user found !!') </script>";
                }
            }
            ViewBag.Login = "<script> alert('No user found !!') </script>";
            return View();
        }




        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}