using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;

namespace MaharajaRestaurant.DAL.Services
{
    public class MenusService:IMenusService
    {
        private MaharajasDbContext dbcontext;
        public MenusService(IMaharajasDBContext dbcontext)
        {
            this.dbcontext = (MaharajasDbContext)dbcontext;
        }

        public int Create(Menu model)
        {
            this.dbcontext.Menus.Add(model);
            this.dbcontext.SaveChanges();
            return model.MenuID;
        }

        public Menu Read(int id)
        {
            return this.dbcontext.Menus.Where(w => w.MenuID == id).FirstOrDefault();
        }

        public IQueryable<Menu> ReadAll()
        {
            return this.dbcontext.Menus.AsQueryable<Menu>();
        }

        public bool Update(Menu model)
        {
            bool status = false;

            Menu tempMenu = this.dbcontext.Menus.Where(w => w.MenuID == model.MenuID).FirstOrDefault();
            if(tempMenu != null)
            {
                tempMenu.Name = model.Name;
                tempMenu.Description = model.Description;
                tempMenu.Type = model.Type;
                tempMenu.Price = model.Price;
                tempMenu.WordAfterPrice = model.WordAfterPrice;

                this.dbcontext.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;

            Menu tempMenu = this.dbcontext.Menus.Where(w => w.MenuID == id).FirstOrDefault();
            if (tempMenu != null)
            {
                this.dbcontext.Menus.Remove(tempMenu);
                this.dbcontext.SaveChanges();
                status = true;
            }
            return status;
        }
    }
}