using BusinessLayer.Abstract;
using CoreLayer.Business.Abstract;
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
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Dal _about2Dal;
        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }



        public async Task AddAsync(About2Dto entity)
        {
            await _about2Dal.AddAsync(entity);
        }

        public void Delete(About2Dto entity)
        {
            _about2Dal.Delete(entity);
        }

        public IQueryable<About2Dto> GetAll()
        {
            return _about2Dal.GetAll();
        }

        public Task<About2Dto> GetByIdAsync(int id)
        {
            return _about2Dal.GetByIdAsync(id);
        }

        public void Update(About2Dto entity)
        {
            _about2Dal.Update(entity);
        }

        public IQueryable<About2Dto> Where(Expression<Func<About2Dto, bool>> expression)
        {
            return _about2Dal.Where(expression);
        }
    }
}
