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
        public Task AddAsync(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Testimonial> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Testimonial> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Testimonial> Where(Expression<Func<Testimonial, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
