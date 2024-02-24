using CoreLayer.DataAccess.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfReservationDal : EfGenericRepository<Reservation>, IReservationDal
    {
        public EfReservationDal(DbContext context) : base(context)
        {
        }
    }
}
