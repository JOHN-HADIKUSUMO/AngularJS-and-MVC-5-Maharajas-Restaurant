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
        [Route("GET/{id}")]
        [AllowAnonymous]
        public HttpResponseMessage Get(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            Menu tempMenu = library.MenusLib.Read(id);

            if (tempMenu == null)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Invalid menu id.");
            }
            else
            {
                outMenuItemDetail temp = new outMenuItemDetail();
                temp.id = tempMenu.MenuID;
                temp.title = tempMenu.Name;
                temp.description = tempMenu.Description;
                temp.price = "$" + tempMenu.Price.ToString() + (tempMenu.WordAfterPrice.Trim()==""?"": tempMenu.WordAfterPrice);
                temp.imgurlhotlevel = @"/Images/Chilli/" + Enum.GetName(typeof(HotLevel), tempMenu.HotScale) + ".gif";

                if(tempMenu.PhotoMenus.Any())
                {
                    temp.imgurl = new List<string>();
                    foreach(PhotoMenu photo in tempMenu.PhotoMenus)
                    {
                        temp.imgurl.Add(@"/Images/Menus/600x600/" + photo.GUIDFilename);
                    }
                }
                else
                {
                    temp.imgurl = new List<string>(){"/Images/Boxes/300x300-Box.png"};
                }

                response = Request.CreateResponse(HttpStatusCode.OK, temp);
            }

            return response;
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

                    string url = @"/Images/" + (menu.PhotoMenus.Any() ? "Menus/300x300/" + menu.PhotoMenus.FirstOrDefault().GUIDFilename : "Boxes/300x300-Box.png");
                    string price = "$" + menu.Price.ToString() + menu.WordAfterPrice.Trim() == "" ? "" : "";
                    row.Add(new MenuItem(menu.MenuID, url, menu.Name,menu.Name.Replace(" ","-").Replace("(","").Replace(")","").Replace("/","").Replace(@"\",""), Word.GetItShortened(menu.Description,15), price,""));

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
