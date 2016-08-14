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
        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre("Appetizers"),
                new Genre("Mains"),
                new Genre("Desserts"),
                new Genre("Drinks")
            };
            return View(genres);
        }

        //
        // GET: /Menu/Browse?genre=Drinks
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);
            return View(genreModel);
        }

        //
        // GET: /Menu/Details/5
        public ActionResult Details(int id = 1)
        {
            Menu Menu = new Menu("Menu " + id);
            return View(Menu);
        }
    }
}