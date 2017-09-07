using PracMVC.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracMVC.Controllers
{
    [MyLogActionFilter]    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration =15)]
        public string Index()
        {
            return "Hello World, this is ASP.Net MVC Tutorials";
        }

        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

    }
}