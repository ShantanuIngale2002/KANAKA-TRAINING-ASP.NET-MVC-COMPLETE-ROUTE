using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Controller.Controllers
{
    public class HomeController : Controller
    {

        /*
         * Controller
            - HERE WE HAVE THIS CONTROLLER AS HomeController inheriting Controller class denoting that its an COntroller class
            - Controller work with user input and requests, It requests to server on behalf user and then using action functions it provides data to corresponding view or to browser request.
                CLIENT(browser) --req--> Server(MVC) 
                THEN
                CLIENT(browser) <--res-- Server(MVC)

         * Action methods
            - Using ACTION METHODS controller handles its process.
            - Default return type is "ActionResult"
            - Only public methods can be access from http req
            - By default All action methods are GET
            - It can return : VIEW, FILE, PARTIAL VIEW, JSON, STRING, etc.
            - browser access : YourDomain/ControllerName/ActionMethod ie. for ex here its localhostxx/home/index
         */


        // GET: Home
        public string Index()
        {
            return "Hello from Index function";
        }

        public string Name()
        {
            return "Hello there my name is Shantanu";
        }

    }
}