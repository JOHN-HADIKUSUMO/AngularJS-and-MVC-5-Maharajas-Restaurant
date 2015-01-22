using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class MenuItem:outMenuItemDetailBase
    {
        public string imgurl { get; set; }
        public string titleforurl { get; set; }

        public MenuItem():base()
        {

        }

        public MenuItem(int id,string imgurl,string title,string titleforurl,string description,string price,string imgurlhotlevel):base(id,title,description,price)
        {
            this.imgurl = imgurl;
            this.titleforurl = titleforurl;
        }
    }
}

