using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMVC.Models
{
    public class Menu
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Menu()
        {

        }
        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public Menu(string Title)
        {
            this.Title = Title;
        }

        public int MenuID { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
}