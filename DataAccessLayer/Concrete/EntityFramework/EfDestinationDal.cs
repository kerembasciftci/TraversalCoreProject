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
    public class EfDestinationDal : EfGenericRepository<DestinationDto>, IDestinationDal
    {
        public EfDestinationDal(DbContext context) : base(context)
        {
        }
    }
}
