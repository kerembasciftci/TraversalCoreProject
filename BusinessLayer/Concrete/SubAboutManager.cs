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
        public Task AddAsync(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SubAbout> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SubAbout> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SubAbout> Where(Expression<Func<SubAbout, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
