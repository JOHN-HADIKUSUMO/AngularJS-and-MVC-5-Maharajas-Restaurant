using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.Models.REST.Reservation;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers.REST
{
    [RoutePrefix("REST/RESERVATION")]
    public class ReservationController : ApiController
    {
        private ILibrary library;
        public ReservationController(ILibrary library)
        {
            this.library = library;
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("Create")]
        public async Task<int> Create(inReservationModel model)
        {
            
            return await Task.FromResult<int>(20);
        }
    }
}
