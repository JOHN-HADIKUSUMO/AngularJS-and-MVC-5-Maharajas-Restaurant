using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Menu
{
    public class outMenuItemDetail
    {
        public int id{get;set;}
        public string imgurl {get;set;}
        public string title {get;set;}
        public string description {get;set;}
        public string price{get;set;}

        public outMenuItemDetail()
        {

        }

        public outMenuItemDetail(int id,string imgurl,string title,string description,string price)
        {
            this.id = id;
            this.imgurl = imgurl;
            this.title = title;
            this.description = description;
            this.price = price;
        }
    }
}

