using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaharajaRestaurant.Custom;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.Models.REST.Reservation;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers.REST
{
    [RoutePrefix("REST/RESERVATION")]
    public class ReservationController:Base
    {
        private CustomUserManager usermanager;
        public ReservationController(ILibrary library):base(library)
        {
            this.library = library;
            usermanager = new CustomUserManager();
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("Create")]
        public Task<HttpResponseMessage> Create(inReservationModel model)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            if(model.yourdetail.firsttimecustomer)
            {
                bool checkusername = this.usermanager.FindByUsernameAsync(model.yourdetail.username).Result;

                if (checkusername)
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Username " + model.yourdetail.username + " has been used.");
                    return Task.FromResult<HttpResponseMessage>(response);
                }

                bool checkemail = this.usermanager.FindByEmailAsync(model.yourdetail.email).Result;

                if (checkemail)
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Email " + model.yourdetail.email + " has been used.");
                    return Task.FromResult<HttpResponseMessage>(response);
                }

                ApplicationUser appuser = new ApplicationUser() { UserName = model.yourdetail.username,Email = model.yourdetail.email,Title = model.yourdetail.title,Firstname = model.yourdetail.lastname,Mobile = model.yourdetail.email };
                var result = this.usermanager.CreateAsync(appuser,model.yourdetail.email, model.yourdetail.password);
                if (!result.Result)
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Fail to create user account " + model.yourdetail.username);
                    return Task.FromResult<HttpResponseMessage>(response);
                }
            }

            Reservation reservation = new Reservation();

            
            return Task.FromResult<HttpResponseMessage>(response);
        }
    }
}
