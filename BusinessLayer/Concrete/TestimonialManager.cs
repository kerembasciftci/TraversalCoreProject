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
    public class TestimonialManager : ITestimonialService
    {
        public Task AddAsync(TestimonialDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TestimonialDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TestimonialDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TestimonialDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TestimonialDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TestimonialDto> Where(Expression<Func<TestimonialDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
