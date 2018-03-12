using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";   
            return View();
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public string Welcome1(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
        public string Welcome2(string name, int ID = 1)

        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}