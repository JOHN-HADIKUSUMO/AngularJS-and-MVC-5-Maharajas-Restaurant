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
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public virtual int MenuID { get; set; }
        public virtual string UserID { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<DateTime> DeletedDate { get; set; }
    }
}