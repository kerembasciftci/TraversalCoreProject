using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        public Task AddAsync(Guide entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Guide> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Guide> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guide entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Guide> Where(Expression<Func<Guide, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
