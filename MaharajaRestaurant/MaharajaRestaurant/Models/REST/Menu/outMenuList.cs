using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class outMenuList
    {
        public List<MenuItem> Items { get; set; }

        public outMenuList()
        {
            this.Items = new List<MenuItem>() { };
        }
    }
}