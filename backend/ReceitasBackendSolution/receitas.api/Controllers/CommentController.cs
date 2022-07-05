using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        ICommentService commentSercvice;
        IRecipeService recipeSercvice;
        IUserService userSercvice;
        public CommentController(ICommentService u, IRecipeService recipe, IUserService user)
        {
            commentSercvice = u;
            recipeSercvice = recipe;
            userSercvice = user;
        }

        // Lista comentários por receita
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {

            if (recipeSercvice.GetRecipeId(id) == null) return NotFound($"O ID:{id} não existe");
            return Ok(commentSercvice.GetComment(id));

        }

        // Media classificação
        [HttpGet("media/{id}")]
        public IActionResult GetMedia(int id)
        {

            if (recipeSercvice.GetRecipeId(id) == null) return NotFound($"O ID:{id} não existe");
            return Ok(commentSercvice.GetMedia(id));

        }

        //Adicionar Comentário
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {

            if (recipeSercvice.GetRecipeId(comment.Idrecipe) == null || userSercvice.ObterUtilizadorID(comment.Iduser) == null) return BadRequest("Existem Id's incorretos");

            commentSercvice.AddComment(comment);
            return Ok();
        }


    }
}
