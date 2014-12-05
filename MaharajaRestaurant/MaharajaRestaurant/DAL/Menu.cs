using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using MaharajaRestaurant.DAL;

namespace MaharajaRestaurant.DAL
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MenusType Type { get; set; }
    }
}