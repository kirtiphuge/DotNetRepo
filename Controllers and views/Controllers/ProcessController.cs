using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracMVC.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Welcome(string name,int numtimes=1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numtimes;

            return View();
        }

        /*public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }

        public ActionResult Welcome()
        {
            return View();
        }*/
    }
}