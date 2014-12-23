using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;

namespace MaharajaRestaurant.DAL.Services
{
    public class ReservationsService : IReservationsService
    {
        private MaharajasDbContext dbcontext;

        public ReservationsService(IMaharajasDBContext dbcontext)
        {
            this.dbcontext = (MaharajasDbContext)dbcontext;
        }

        public int Create(Reservation model)
        {
            this.dbcontext.Reservations.Add(model);
            this.dbcontext.SaveChanges();
            return model.ReservationID;
        }

        public Reservation Read(int id)
        {
            return this.dbcontext.Reservations.Where(w => w.ReservationID == id).FirstOrDefault();
        }

        public IQueryable<Reservation> ReadAll()
        {
            return this.dbcontext.Reservations.AsQueryable<Reservation>();
        }

        public bool Update(Reservation model)
        {
            bool status = false;

            Reservation tempReservation = this.dbcontext.Reservations.Where(w => w.ReservationID == model.ReservationID).FirstOrDefault();
            if (tempReservation != null)
            {
                tempReservation.ReservationID = model.ReservationID;
                this.dbcontext.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;

            Reservation tempReservation = this.dbcontext.Reservations.Where(w => w.ReservationID == id).FirstOrDefault();
            if (tempReservation != null)
            {
                this.dbcontext.Reservations.Remove(tempReservation);
                this.dbcontext.SaveChanges();
                status = true;
            }
            return status;
        }
    }
}