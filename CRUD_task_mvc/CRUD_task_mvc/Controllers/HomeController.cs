using MyAppDB.DBoperations;
using MyAppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_task_mvc.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository = null;
        public HomeController() {
            repository = new EmployeeRepository();
        }
        public ActionResult Create()
        {
            return View();
        }
        // GET: Home
        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.addEmployee(model);

                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data Successfully added !!";
                }
            }
            return View();
        }
    }
}