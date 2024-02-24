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
    public class Feature2Manager : IFeature2Service
    {
        public Task AddAsync(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feature2> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Feature2> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feature2> Where(Expression<Func<Feature2, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
