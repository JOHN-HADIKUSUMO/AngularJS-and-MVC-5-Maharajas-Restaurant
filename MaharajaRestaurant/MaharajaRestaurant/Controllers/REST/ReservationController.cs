using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.Models.REST.Reservation;

namespace MaharajaRestaurant.Controllers.REST
{
    [RoutePrefix("REST/RESERVATION")]
    public class ReservationController : ApiController
    {
        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("Create")]
        public Task<bool> Create(inReservationModel model)
        {
            return Task.FromResult<Boolean>(true);
        }
    }
}
