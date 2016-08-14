using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMVC.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Genre()
        {

        }
        /// <summary>
        /// This constructor takes on parameter - Name
        /// </summary>
        public Genre(string Name)
        {
            this.Name = Name;
        }

        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}