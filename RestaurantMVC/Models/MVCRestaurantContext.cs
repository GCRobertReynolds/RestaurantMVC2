using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantMVC.Models
{
    public class MVCRestaurantContext : DbContext
    {
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Mains> Mains { get; set; }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
    }
}