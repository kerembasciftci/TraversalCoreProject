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
        public Task AddAsync(NewsLetter entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewsLetter entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsLetter> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NewsLetter> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsLetter> Where(Expression<Func<NewsLetter, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
