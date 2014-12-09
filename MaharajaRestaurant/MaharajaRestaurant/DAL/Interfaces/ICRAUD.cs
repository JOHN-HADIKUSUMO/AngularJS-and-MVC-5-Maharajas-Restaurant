using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;

namespace MaharajaRestaurant.DAL.Interfaces
{
    public interface ICRAUD<T0,T1,T2>
    {
        T1 Create(T0 model);
        T0 Read(int id);
        IQueryable<T0> ReadAll();
        T2 Update(T0 model);
        T2 Delete(int id);
    }
}