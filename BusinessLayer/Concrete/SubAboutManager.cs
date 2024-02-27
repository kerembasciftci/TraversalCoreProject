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
    public class SubAboutManager : ISubAboutService
    {
        public Task AddAsync(SubAboutDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAboutDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SubAboutDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SubAboutDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAboutDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SubAboutDto> Where(Expression<Func<SubAboutDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
