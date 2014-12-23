using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using MaharajaRestaurant.Business.Interfaces;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.Models.REST.Reservation;

namespace MaharajaRestaurant.Controllers.REST
{
    [RoutePrefix("REST/MENUS")]
    public class MenusController :Base
    {
        public MenusController(ILibrary library)
            : base(library)
        {

        }

        //[HttpPost]
        //[AcceptVerbs("POST")]
        //[Route("Create")]
        //public async Task<bool> GetAll()
        //{
        //    return await 
        //}
    }
}
