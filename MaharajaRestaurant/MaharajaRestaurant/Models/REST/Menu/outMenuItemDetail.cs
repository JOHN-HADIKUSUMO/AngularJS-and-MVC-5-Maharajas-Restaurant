using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class outMenuItemDetail:outMenuItemDetailBase
    {
        public List<string> imgurl {get;set;}
        public string imgurlhotlevel { get; set; }

        public outMenuItemDetail()
        {

        }

        public outMenuItemDetail(int id, List<string> imgurl, string title, string description, string price, string imgurlhotlevel):base(id,title,description,price)
        {
            this.id = id;
            this.imgurl = imgurl;
            this.title = title;
            this.description = description;
            this.price = price;
            this.imgurlhotlevel = imgurlhotlevel;
        }
    }
}

