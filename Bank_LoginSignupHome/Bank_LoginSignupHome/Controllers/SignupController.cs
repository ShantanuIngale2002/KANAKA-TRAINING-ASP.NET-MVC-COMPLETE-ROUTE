using Bank_LoginSignupHome.Data;
using Bank_LoginSignupHome.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace Bank_LoginSignupHome.Controllers
{
    public class SignupController : Controller
    {
        UserContext db = new UserContext();
        // GET: Signup
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SignupModel u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Random rand = new Random();
                    int randomacc;

                    do
                    {
                        randomacc = rand.Next(100000000, 999999999);
                    } while (db.Users.Any(m => m.AccountNumber == randomacc));

                    var user = new User()
                    {
                        AccountNumber = randomacc,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Gender = u.Gender,
                        Contact = u.Contact,
                        AddressPincode = u.AddressPincode,
                        Email = u.Email,
                        Password = u.Password,
                    };

                    db.Users.Add(user);
                    db.SaveChanges();

                    ViewBag.Insert = "<script> alert('Data Inserted !!') </script>";
                    return RedirectToAction("Index", "Login");
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during database interaction
                    ViewBag.Error = $"<script> alert('An error occurred: {ex.Message}') </script>";
                    return View(u);
                }
            }
            return View();
        }

        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Signup");
        }
    }
}