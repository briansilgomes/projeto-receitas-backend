using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;

namespace receitas.api.Controllers
{
    [Route("api/recipeingredient")]
    [ApiController]
    public class RecipeIngredientController : ControllerBase
    {
        ITempService tempService;
        IRecipeService recipeService;
        IUserService userService;
        public RecipeIngredientController(ITempService u, IRecipeService recipe, IUserService user)
        {
            tempService = u;
            recipeService = recipe;
            userService = user;
        }


        //Enviar para a Real
        [HttpGet("{idrecipe}/{iduser}")]
        public IActionResult SendTempReal(int idrecipe, int iduser)
        {
            if (recipeService.GetRecipeId(idrecipe) == null || userService.ObterUtilizadorID(iduser) == null) return BadRequest("Id não existe");
            return Ok(tempService.SendTempReal(idrecipe, iduser));
        }

        //Remover da real
        [HttpGet("removeall/{idrecipe}")]
        public IActionResult RemoveAllReal(int idrecipe)
        {
            if(recipeService.GetRecipeId(idrecipe) == null) return BadRequest("Id não existe");
            return Ok(tempService.RemoveAllReal(idrecipe));
        }

        //Remover do temorario
        [HttpGet("{iduser}")]
        public IActionResult RemoveAll(int iduser)
        {
            if(userService.ObterUtilizadorID(iduser) == null) return BadRequest("Id não existe");
            return Ok(tempService.RemoveAll(iduser));
        }

       

    }
}
