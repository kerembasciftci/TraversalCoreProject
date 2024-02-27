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
    public class ReservationManager : IReservationService
    {
        public Task AddAsync(ReservationDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ReservationDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ReservationDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ReservationDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ReservationDto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ReservationDto> Where(Expression<Func<ReservationDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
