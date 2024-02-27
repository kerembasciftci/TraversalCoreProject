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
    public class EfSubAboutDal : EfGenericRepository<SubAboutDto>, ISubAboutDal
    {
        public EfSubAboutDal(DbContext context) : base(context)
        {
        }
    }
}
