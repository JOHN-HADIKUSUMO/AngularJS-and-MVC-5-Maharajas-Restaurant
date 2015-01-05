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
    public class MenusController :Base
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

            if (category == "")
            {
                List<List<MenuItem>> ret = new List<List<MenuItem>>() { };

                IQueryable<Menu> tempmenus = library.MenusLib.ReadAll();
                if(tempmenus != null)
                {
                    int count = 0;
                    foreach(Menu menu in tempmenus)
                    {
                        List<MenuItem> row = new List<MenuItem>() { };
                        row.Add(new MenuItem(10, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                        row.Add(new MenuItem(11, "/Images/Boxes/300x300-Box.png", "Sed ante nulla, molestie eu ipsum id.", "Etiam ac tempor tortor, id viverra massa. Vestibulum eros nunc, rutrum sed lacus et, ultrices pulvinar turpis.", "$2.50 (3pcs)"));
                        row.Add(new MenuItem(12, "/Images/Boxes/300x300-Box.png", "Quisque a arcu tortor.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                        row.Add(new MenuItem(13, "/Images/Boxes/300x300-Box.png", "Fusce posuere tristique mi et.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                        ret.Add(row);
                    }
                }



                response = Request.CreateResponse(HttpStatusCode.OK, ret);

            }
            else
            {
                try
                {
                    int cat = (int)Enum.Parse(typeof(MenusType), category, true);

                    List<List<MenuItem>> ret = new List<List<MenuItem>>() { };

                    List<MenuItem> row_0 = new List<MenuItem>() { };
                    row_0.Add(new MenuItem(10, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_0.Add(new MenuItem(11, "/Images/Boxes/300x300-Box.png", "Sed ante nulla, molestie eu ipsum id.", "Etiam ac tempor tortor, id viverra massa. Vestibulum eros nunc, rutrum sed lacus et, ultrices pulvinar turpis.", "$2.50 (3pcs)"));
                    row_0.Add(new MenuItem(12, "/Images/Boxes/300x300-Box.png", "Quisque a arcu tortor.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_0.Add(new MenuItem(13, "/Images/Boxes/300x300-Box.png", "Fusce posuere tristique mi et.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));

                    ret.Add(row_0);

                    List<MenuItem> row_1 = new List<MenuItem>() { };
                    row_1.Add(new MenuItem(14, "/Images/Boxes/300x300-Box.png", "Sed ante nulla, molestie eu ipsum id", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_1.Add(new MenuItem(15, "/Images/Boxes/300x300-Box.png", "Quisque a arcu tortor.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_1.Add(new MenuItem(16, "/Images/Boxes/300x300-Box.png", "Fusce posuere tristique mi et.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_1.Add(new MenuItem(17, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));

                    ret.Add(row_1);

                    List<MenuItem> row_2 = new List<MenuItem>() { };
                    row_2.Add(new MenuItem(18, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_2.Add(new MenuItem(19, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_2.Add(new MenuItem(20, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_2.Add(new MenuItem(21, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));

                    ret.Add(row_2);

                    List<MenuItem> row_3 = new List<MenuItem>() { };
                    row_3.Add(new MenuItem(22, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_3.Add(new MenuItem(23, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));
                    row_3.Add(new MenuItem(24, "/Images/Boxes/300x300-Box.png", "Integer et pretium velit.", "Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.", "$2.50 (3pcs)"));

                    ret.Add(row_3);

                    response = Request.CreateResponse(HttpStatusCode.OK, ret);
                }
                catch(Exception ex)
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Invalid Menu Type parameter.");
                }
            }

            return response;
        }
 
    }
}
