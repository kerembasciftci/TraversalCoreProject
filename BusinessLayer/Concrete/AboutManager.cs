using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }



        public async Task AddAsync(About entity)
        {
           await _aboutDal.AddAsync(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public IQueryable<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public Task<About> GetByIdAsync(int id)
        {
            return _aboutDal.GetByIdAsync(id);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }

        public IQueryable<About> Where(Expression<Func<About, bool>> expression)
        {
            return _aboutDal.Where(expression);
        }
    }
}
