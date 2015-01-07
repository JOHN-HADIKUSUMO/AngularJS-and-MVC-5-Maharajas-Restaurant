using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Threading.Tasks;
using MaharajaRestaurant.Business.Interfaces;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.Models.REST.Menu;
using MaharajaRestaurant.Utility;

namespace MaharajaRestaurant.Controllers.REST
{
    [RoutePrefix("REST/MENUS")]
    public class MenusController : Base
    {
        public MenusController(ILibrary library)
            : base(library)
        {

        }


        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("GETALL/{category?}")]
        [AllowAnonymous]
        public HttpResponseMessage GetAll(string category = "")
        {
            HttpResponseMessage response = new HttpResponseMessage();
            List<Menu> tempmenus = new List<Menu>() { };
            List<List<MenuItem>> ret = new List<List<MenuItem>>() { };
            if (category == "")
            {
                tempmenus = library.MenusLib.ReadAll().ToList<Menu>();

            }
            else
            {
                try
                {
                    MenusType type = (MenusType)Enum.Parse(typeof(MenusType), category);
                    tempmenus = library.MenusLib.ReadAll(type).ToList<Menu>();
                }
                catch(Exception ex)
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Invalid Menu Type.");
                    return response;
                }
            }
            
            if (tempmenus != null)
            {
                List<MenuItem> row = null;
                int count = 0;
                foreach (Menu menu in tempmenus)
                {
                    if(count == 0)
                    {
                        row = new List<MenuItem>() { };
                    }

                    string url = @"/Images/" + (menu.PhotoMenus.Any() ? "Menus/" + menu.PhotoMenus.FirstOrDefault().GUIDFilename : "Boxes/300x300-Box.png");
                    string price = "$" + menu.Price.ToString() + menu.WordAfterPrice.Trim() == "" ? "" : "";
                    row.Add(new MenuItem(menu.MenuID, url, menu.Name,menu.Name.Replace(" ","-"), Word.GetItShortened(menu.Description,15), price));

                    count++;
                   
                    if (count >= 4)
                    {
                        ret.Add(row);
                        count = 0;
                        row = new List<MenuItem>() { };
                    }
                }

                if (row != null && count < 4)
                {
                    ret.Add(row);
                }
            }



            response = Request.CreateResponse(HttpStatusCode.OK, ret);



            return response;
        }

    }
}
