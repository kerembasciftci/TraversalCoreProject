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
        public Task AddAsync(DestinationDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DestinationDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DestinationDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DestinationDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DestinationDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DestinationDto> Where(Expression<Func<DestinationDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
