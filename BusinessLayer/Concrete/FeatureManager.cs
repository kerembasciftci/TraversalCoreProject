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
        public Task AddAsync(FeatureDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FeatureDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FeatureDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<FeatureDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(FeatureDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FeatureDto> Where(Expression<Func<FeatureDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
