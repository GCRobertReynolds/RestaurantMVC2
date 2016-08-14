using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVC.Models;

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
        // GET: /Menu/Browse?genre=Drinks
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Menu.Browse, Genre= " + genre);
            return message;
        }

        //
        // GET: /Menu/Details/5
        public ActionResult Details(int id = 1)
        {
            var Menu = new Menu("Menu " + id);
            return View(Menu);
        }
    }
}