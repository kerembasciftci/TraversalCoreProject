using BusinessLayer.Abstract;
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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;   
        }



        public async Task AddAsync(CommentDto entity)
        {
            await _commentDal.AddAsync(entity);
        }

        public void Delete(CommentDto entity)
        {
            _commentDal.Delete(entity);
        }

        public IQueryable<CommentDto> GetAll()
        {
            return _commentDal.GetAll();
        }

        public async Task<CommentDto> GetByIdAsync(int id)
        {
            return await _commentDal.GetByIdAsync(id);
        }

        public void Update(CommentDto entity)
        {
            _commentDal.Update(entity);
        }

        public IQueryable<CommentDto> Where(Expression<Func<CommentDto, bool>> expression)
        {
            return _commentDal.Where(expression);
        }
    }
}
