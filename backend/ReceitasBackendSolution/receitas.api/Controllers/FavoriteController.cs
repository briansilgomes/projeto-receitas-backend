using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
    [Route("api/favorite")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {

        IFavoriteService favoriteService;
        IRecipeService recipeService;
        IUserService userService;
        public FavoriteController(IFavoriteService u, IRecipeService recipe, IUserService user)
        {
            favoriteService = u;
            recipeService = recipe;
            userService = user;
        }

        // Favorito de um Utilizador
        [HttpGet("{id}")]
        public IActionResult GetFavorite(int id)
        {

            if (userService.ObterUtilizadorID(id) == null) return NotFound("Utilizador não existe");      
            return Ok(favoriteService.GetFavorite(id));
        }

        // Verifica se a receita esta em favorito para aquele utilizador - detalhes da receita
        [HttpGet("{idreceita}/{iduser}")]
        public IActionResult ValidateFavoriteUser(int idreceita, int iduser)
        {

            //if (recipeService.GetRecipeId(idreceita) == null || userService.ObterUtilizadorID(iduser) == null) return BadRequest("Existem Id's incorretos");

            return Ok(favoriteService.ValidateFavoriteUser(idreceita, iduser));
        }

        // Adicionar Favorito
        [HttpPost]
        public IActionResult AddFavorite(Favorite favorite)
        {

            if (recipeService.GetRecipeId(favorite.Idrecipe) == null || userService.ObterUtilizadorID(favorite.Iduser) == null) return BadRequest("Existem Id's incorretos");
            if (favoriteService.ValidateFavoriteUser(favorite.Idrecipe, favorite.Iduser) != null) return BadRequest("Receita já foi adicionada à lista de fav.do utilizador");

            favoriteService.AddFavorite(favorite);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + favorite.Idfavorite, favorite);

        }

        // Remover Favorito
        [HttpDelete("{id}")]
        public IActionResult RemoveFavorite(int id)
        {
            
            if (favoriteService.GetFavorite(id) == null) return BadRequest($"O ID:{id} não existe");
            return Ok(favoriteService.RemoveFavorite(id));
        }

    }
}
