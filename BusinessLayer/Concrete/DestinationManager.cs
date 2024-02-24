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
    public class DestinationManager : IDestinationService
    {
        public Task AddAsync(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Destination> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Destination> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Destination entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Destination> Where(Expression<Func<Destination, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
