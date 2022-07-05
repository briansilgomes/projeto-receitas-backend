using receitas.entidades;

namespace receitas.api.Services
{
    public interface ICommentService
    {
        List<CommentModel> GetComment(int id);
        Classification GetMedia(int id);
        Comment AddComment(Comment comment);
    }
}
