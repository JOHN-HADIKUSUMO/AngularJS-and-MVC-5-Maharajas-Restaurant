using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class outMenuItemDetailBase
    {
        public int id{get;set;}
        public string title {get;set;}
        public string description {get;set;}
        public string price{get;set;}

        public outMenuItemDetailBase()
        {

        }

        public outMenuItemDetailBase(int id, string title, string description, string price)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
        }
    }
}

