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
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string NumberOfPeople { get; set; }
        public int Environment { get; set; }
        public int PaymentMethod { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<DateTime> DeletedDate { get; set; }
        public virtual ApplicationUser Customer { get; set; }

    }
}