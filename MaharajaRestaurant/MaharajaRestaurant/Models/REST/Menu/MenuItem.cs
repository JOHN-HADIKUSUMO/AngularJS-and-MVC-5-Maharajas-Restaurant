using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class MenuItem:outMenuItemDetail
    {
        public string titleforurl { get; set; }

        public MenuItem():base()
        {

        }

        public MenuItem(int id,string imgurl,string title,string titleforurl,string description,string price):base(id,imgurl,title,description,price)
        {
            this.titleforurl = titleforurl;
        }
    }
}

