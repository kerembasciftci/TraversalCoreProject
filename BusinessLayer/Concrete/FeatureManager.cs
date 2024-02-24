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
    public class FeatureManager : IFeatureService
    {
        public Task AddAsync(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feature> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Feature> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feature> Where(Expression<Func<Feature, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
