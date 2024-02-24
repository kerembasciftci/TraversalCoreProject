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
        public Task AddAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> Where(Expression<Func<Contact, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
