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
        public Task AddAsync(GuideDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GuideDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GuideDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GuideDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(GuideDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GuideDto> Where(Expression<Func<GuideDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
