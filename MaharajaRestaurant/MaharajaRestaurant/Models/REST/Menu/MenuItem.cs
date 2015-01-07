using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class MenuItem
    {
        public int id{get;set;}
        public string imgurl {get;set;}
        public string title {get;set;}
        public string titleforurl { get; set; }
        public string description {get;set;}
        public string price{get;set;}

        public MenuItem()
        {

        }

        public MenuItem(int id,string imgurl,string title,string titleforurl,string description,string price)
        {
            this.id = id;
            this.imgurl = imgurl;
            this.title = title;
            this.titleforurl = titleforurl;
            this.description = description;
            this.price = price;
        }
    }
}

