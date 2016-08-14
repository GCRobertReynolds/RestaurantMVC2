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
        // GET: /Menu/Browse?genre=Drinks
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Menu.Browse, Genre= " + genre);
            return message;
        }

        //
        // GET: /Menu/Details/5
        public string Details(int id = 1)
        {
            string message = "Menu.Details, ID = " + id;

            return message;
        }
    }
}