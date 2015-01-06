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
                MenusType type = (MenusType)Enum.Parse(typeof(MenusType), category);
                tempmenus = library.MenusLib.ReadAll(type).ToList<Menu>();
            }
            
            if (tempmenus != null)
            {
                List<MenuItem> row = new List<MenuItem>() { };
                int count = 0;
                foreach (Menu menu in tempmenus)
                {
                    string url = @"/Images/" + (menu.PhotoMenus.Any() ? "Menus/" + menu.PhotoMenus.FirstOrDefault().GUIDFilename : "Boxes/300x300-Box.png");
                    string price = "$" + menu.Price.ToString() + menu.WordAfterPrice.Trim() == "" ? "" : "";
                    row.Add(new MenuItem(menu.MenuID, url, menu.Name, menu.Description, price));

                    count++;
                   
                    if (count >= 4)
                    {
                        ret.Add(row);
                        count = 0;
                        row = new List<MenuItem>() { };
                    }
                }

                if (count < 4)
                {
                    ret.Add(row);
                }
            }



            response = Request.CreateResponse(HttpStatusCode.OK, ret);



            return response;
        }

    }
}
