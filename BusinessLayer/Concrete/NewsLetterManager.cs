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
    public class NewsLetterManager : INewsLetterService
    {
        public Task AddAsync(NewsLetterDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewsLetterDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsLetterDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NewsLetterDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetterDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsLetterDto> Where(Expression<Func<NewsLetterDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
