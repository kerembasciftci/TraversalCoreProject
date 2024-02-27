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
        public Task AddAsync(Feature2Dto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature2Dto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feature2Dto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Feature2Dto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature2Dto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feature2Dto> Where(Expression<Func<Feature2Dto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
