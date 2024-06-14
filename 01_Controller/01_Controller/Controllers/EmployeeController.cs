using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Controller.Controllers
{
    public class EmployeeController : Controller
    {
        /*
         * if it goes to homeController first then u can do this
         * since we can access like domain/ControllerName/ActionMethod
         */

        // we can do this : localhostxx//Employee/EmployeeProfile?id=01
        public string EmployeeProfile(int id)
        {
            string profile = "Defualt profile";
            if (id == 1) { profile = "This is Profile 01."; }
            else if (id == 2) { profile = "This is Profile 02."; }
            
            return profile;
        }

        // we can do this : localhostxx//Employee/EmployeeAddress?id=0&dept=CS/IT
        public string EmployeeDepartment(int id, string dept)
        {
            return "For Employee with id " + id + ", the department is " + dept;
        }

        // to make a parameter required we can do it like
        // dataType? name=default_value ex. int? id=2;
    }
}