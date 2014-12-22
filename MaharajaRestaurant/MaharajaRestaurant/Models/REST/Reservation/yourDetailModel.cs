using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Reservation
{
    public class yourDetailModel
    {
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public bool firsttimecustomer { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string conpassword { get; set; }
    }
}