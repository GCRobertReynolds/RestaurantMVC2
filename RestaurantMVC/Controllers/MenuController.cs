using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMVC.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/
        public string Index()
        {
            return "Hello from Menu.Index()";
        }
        //
        // GET: /Menu/Browse
        public string Browse()
        {
            return "Hello from Menu.Browse()";
        }
        //
        // GET: /Menu/Details
        public string Details()
        {
            return "Hello from Menu.Details()";
        }
    }
}