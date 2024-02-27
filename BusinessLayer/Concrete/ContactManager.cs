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
    public class ContactManager : IContactService
    {
        public Task AddAsync(ContactDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ContactDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ContactDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ContactDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ContactDto> Where(Expression<Func<ContactDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
