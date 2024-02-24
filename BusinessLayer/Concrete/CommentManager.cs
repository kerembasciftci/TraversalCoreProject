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



        public async Task AddAsync(Comment entity)
        {
            await _commentDal.AddAsync(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public IQueryable<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            return await _commentDal.GetByIdAsync(id);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public IQueryable<Comment> Where(Expression<Func<Comment, bool>> expression)
        {
            return _commentDal.Where(expression);
        }
    }
}
