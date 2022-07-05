using receitas.entidades;

namespace receitas.api.Data
{
    public class CommentDao : ICommentDao
    {

        ReceitasDbContext receitasdb;
        public CommentDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public Comment AddComment(Comment comment)
        {
            receitasdb.Comentarios.Add(comment);
            receitasdb.SaveChanges();
            return comment;
        }

        public List<CommentModel> GetComment(int id)
        {
            var result = ( from comment in receitasdb.Comentarios
                          
                           join recipe in receitasdb.Receitas
                           on comment.Idrecipe equals recipe.Idrecipe
                           
                           join user in receitasdb.Utilizadores
                           on comment.Iduser equals user.Iduser

                           where recipe.Idrecipe == id
                           
                           select new CommentModel
                           {
                               Idcomment =  comment.Idcomment,
                               Commentrecipe = comment.Commentrecipe,
                               Classificationrecipe = comment.Classificationrecipe,
                               Username = user.Nameuser,
                               Datecomment = comment.DateComment,
                               Userimage = user.Userimage,


                           }


                  ).ToList();

            return result.ToList();
        }

        public Classification GetMedia(int id)
        {

           var resultCount = (from comment in receitasdb.Comentarios
                         where comment.Idrecipe == id
                         select comment.Classificationrecipe).Count();
            
            var resultSoma = (from comment in receitasdb.Comentarios
                               where comment.Idrecipe == id
                               select comment.Classificationrecipe).Sum();

            Classification classification = new Classification();
            if (resultCount == 0 || resultSoma == 0)
            {
                classification.Mediaclassification = 0;
            }
            else
            {
                var result = resultSoma / resultCount;

                classification.Mediaclassification = result;
            }

         
            return classification;
        }


    }
}
