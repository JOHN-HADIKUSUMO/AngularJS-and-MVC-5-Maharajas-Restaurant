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
    [Table("PhotoMenus")]
    public class PhotoMenu
    {
        [Key]
        public int PhotoID { get; set; }
        public int MenuID { get; set; }
        public string Filename { get; set; }
        public string GUIDFilename { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<DateTime> DeletedDate { get; set; }
    }
}