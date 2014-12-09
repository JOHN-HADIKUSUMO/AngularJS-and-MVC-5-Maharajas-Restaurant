using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;

namespace MaharajaRestaurant.DAL.Services
{
    public class PhotoMenusService : IPhotoMenusService
    {
        private MaharajasDbContext dbcontext;

        public PhotoMenusService(IMaharajasDBContext dbcontext)
        {
            this.dbcontext = (MaharajasDbContext)dbcontext;
        }

        public int Create(PhotoMenu model)
        {
            this.dbcontext.PhotoMenus.Add(model);
            this.dbcontext.SaveChanges();
            return model.PhotoMenuID;
        }

        public PhotoMenu Read(int id)
        {
            return this.dbcontext.PhotoMenus.Where(w => w.MenuID == id).FirstOrDefault();
        }

        public IQueryable<PhotoMenu> ReadAll()
        {
            return this.dbcontext.PhotoMenus.AsQueryable<PhotoMenu>();
        }

        public bool Update(PhotoMenu model)
        {
            bool status = false;

            PhotoMenu tempPhotoMenu = this.dbcontext.PhotoMenus.Where(w => w.PhotoMenuID == model.PhotoMenuID).FirstOrDefault();
            if (tempPhotoMenu != null)
            {
                tempPhotoMenu.MenuID = model.MenuID;
                tempPhotoMenu.Filename = model.Filename;
                tempPhotoMenu.GUIDFilename = model.GUIDFilename;
                this.dbcontext.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;

            PhotoMenu tempPhotoMenu = this.dbcontext.PhotoMenus.Where(w => w.PhotoMenuID == id).FirstOrDefault();
            if (tempPhotoMenu != null)
            {
                this.dbcontext.PhotoMenus.Remove(tempPhotoMenu);
                this.dbcontext.SaveChanges();
                status = true;
            }
            return status;
        }
    }
}