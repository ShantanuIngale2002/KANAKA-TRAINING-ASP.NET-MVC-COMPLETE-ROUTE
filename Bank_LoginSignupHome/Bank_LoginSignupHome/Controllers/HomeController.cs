using Bank_LoginSignupHome.Data;
using Bank_LoginSignupHome.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Security.Cryptography;

namespace Bank_LoginSignupHome.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        // GET: Home
        public ActionResult Index()
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            int userId = (int)Session["userid"];
            var data = db.Users.Find(userId);

            return View(data);
        }

        public ActionResult Details()
        {
            int userId = (int)Session["userid"];
            var rows = db.Users.Where(model => model.Id == userId).FirstOrDefault();
            return View(rows);
        }


        public ActionResult Edit()
        {
            int userId = (int)Session["userid"];
            var rows = db.Users.Where(model => model.Id == userId).FirstOrDefault();
            return View(rows);
        }

        [HttpPost]
        public ActionResult Edit(SignupModel s)
        {
            if(ModelState.IsValid)
            {
                int userId = (int)Session["userid"];
                User user = db.Users.Find(userId);
                if(user!=null){
                    user.FirstName = s.FirstName;
                    user.LastName = s.LastName;
                    user.Gender = s.Gender;
                    user.Contact = s.Contact;
                    user.AddressPincode = s.AddressPincode;
                    user.Email = s.Email;
                    user.Password = s.Password;
                };
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                int rows = db.SaveChanges();

                if(rows > 0)
                {
                    ViewBag.Edited="<script> alert('Successfully Edited !!') </script>";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Edited="<script> alert('Editing is Failed !!') </script>";
                }
            }
            return View();
        }




        public ActionResult Delete()
        {
            int userId = (int)Session["userid"];
            var raw = db.Users.Where(model => model.Id == userId).FirstOrDefault();
            return View(raw);
        }

        [HttpPost]
        public ActionResult Delete(SignupModel s)
        {
            if (ModelState.IsValid) {

                int userid = (int)Session["userid"];
                User user = db.Users.Find(userid);
                if(user != null)
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    Session["userid"] = null;
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    ViewBag.Deleted = "<script> alert('Deleting is Failed !!') </script>";
                }
            }
            return View();
        }




        public ActionResult Logout()
        {
            Session["userid"] = null;
            return RedirectToAction("Index", "Login");
        }

    }
}