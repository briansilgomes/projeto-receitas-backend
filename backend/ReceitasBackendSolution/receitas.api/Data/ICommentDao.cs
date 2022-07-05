using receitas.entidades;

namespace receitas.api.Data
{
    public interface ICommentDao
    {
        List<CommentModel> GetComment(int id);
        Classification GetMedia(int id);
        Comment AddComment(Comment comment);

    }
}
