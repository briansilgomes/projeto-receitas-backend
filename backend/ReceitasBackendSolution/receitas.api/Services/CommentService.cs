using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{
    public class CommentService : ICommentService
    {
        ICommentDao commentDao;
        public CommentService(ICommentDao dao)
        {
            commentDao = dao;
        }

        public Comment AddComment(Comment comment)
        {
            return commentDao.AddComment(comment);
        }

        public List<CommentModel> GetComment(int id)
        {
           return commentDao.GetComment(id);
        }

        public Classification GetMedia(int id)
        {
           return commentDao.GetMedia(id);
        }
    }
}
