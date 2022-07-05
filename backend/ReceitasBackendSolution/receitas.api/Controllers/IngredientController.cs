using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
    [Route("api/ingredient")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        IIngredientSercvice ingredientSercvice;
        ITempService tempService;
        IUserService userService;
        IRecipeService recipeService;
        
        public IngredientController(IIngredientSercvice u, ITempService t, IUserService user, IRecipeService recipe)
        {
            ingredientSercvice = u;
            tempService = t;
            userService = user;
            recipeService = recipe;
           
        }

        // List de Ingredientes
        [HttpGet]
        public IActionResult GetIngredient()
        {
            return Ok(ingredientSercvice.GetIngredient());
        }

        // List - Ingrediente por ID
        [HttpGet("{id}")]
        public IActionResult GetDetail(int id)
        {
           
            if (ingredientSercvice.GetDetail(id) == null) return NotFound($"O ID:{id} não existe");
            return Ok(ingredientSercvice.GetDetail(id));

        }

        // List - Ingredientes da Receita
        [HttpGet("ingredientrecipe/{id}")]
        public IActionResult GetIngredientRecipe(int id)
        {
       
            if(ingredientSercvice.GetRecipeIngredient(id).Count == 0) return NotFound($"O ID:{id} não existe");
            return Ok(ingredientSercvice.GetRecipeIngredient(id));

        }

        [HttpGet("search/{search}")]
        public IActionResult GetResultSearch(string search)
        {
           
            return Ok(ingredientSercvice.ResultSearch(search));
        }

        //Adicionar Ingrediente
        [HttpPost]
        public IActionResult AddIngredient(Ingredient ingre)
        {
            if (ingredientSercvice.ValidateIngredient(ingre) != null) return BadRequest("O ingrediente já existe");
            
            ingredientSercvice.AddIngredient(ingre);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + ingre.Idingredient,ingre);
        }

        // Alterar Ingrediente
        [HttpPut]
        public IActionResult UpdateIngredient(Ingredient ingre)
        {
           
            if (ingredientSercvice.ValidateIngredient(ingre) != null) return BadRequest($"O ingrediente já existe ou o ID:{ingre.Idingredient} não é valido");
            return Ok(ingredientSercvice.UpdateIngredient(ingre));

        }

        //Validar Ingrediente
        [HttpPost ("validate")]
        public IActionResult ValidateIngredient(Ingredient ingre)
        {
 
            if (ingredientSercvice.ValidateIngredient(ingre) == null) return Ok();
            return Ok(ingredientSercvice.ValidateIngredient(ingre));

        }




        // TEMPORARIOS - Ingredientes

        // Add - Temporario
        [HttpPost("temporary")]
        public IActionResult AddRecipeIngredient(Temp temp)
        {
         
            try
            {
                tempService.AddTemporary(temp);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + temp.Iduser, temp);
            }
            catch (Exception ex)
            {
                return BadRequest("Id's inválidos");
            }
           
        }

        // Delete - Temporario
        [HttpDelete("temporary/{idtemp}")]
        public IActionResult DeleteRecipeIngredient(int idtemp)
        {

               if (tempService.RemoveTemporary(idtemp) == null) return BadRequest("Id inválido");
               return Ok();
           
        }

        // List - Temporarios por utilizador
        [HttpGet("temp/{iduser}")]
        public IActionResult GetTemporary(int iduser)
        {
            if (userService.ObterUtilizadorID(iduser) == null) return BadRequest("O ID não existe");
            return Ok(tempService.GetTemporary(iduser));
        }

        // List - Add Real para Temporario (editar)
        [HttpGet("realtotemp/{idrecipe}/{iduser}")]
        public IActionResult SendRealTemp(int idrecipe, int iduser)
        {
            if (userService.ObterUtilizadorID(iduser) == null || recipeService.GetRecipeId(idrecipe) == null) return BadRequest("Existem ID's não existe");
            return Ok(tempService.SendRealTemp(idrecipe, iduser));
        }


        //????
        [HttpGet("temporary/{idrecipe}")]
        public IActionResult SendTempReal(int idrecipe)
        {
            var u = tempService.GetTemporary(idrecipe);

            if (u == null)
            {
                return NotFound();
            }
            return Ok(u);
        }



        
    }
}
