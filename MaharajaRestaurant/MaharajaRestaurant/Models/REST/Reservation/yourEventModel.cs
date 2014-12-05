using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaharajaRestaurant.Models.REST.Reservation
{
    public class yourEventModel
    {
        public string name { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string numberofpeople { get; set; }
        public int environment { get; set; }
        public int paymentmethod { get; set; }
    }
}