using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        IRecipeService recipeSercvice;
        ICategoryService categoryService;
        IUserService userService;

        private readonly IWebHostEnvironment _environment;

        public RecipeController(IRecipeService u, ICategoryService category, IUserService user, IWebHostEnvironment environment)
        {
            recipeSercvice = u;
            categoryService = category;
            userService = user;
            _environment = environment;

        }

        //Lista - Receitas
        [HttpGet]
        public IActionResult GetRecipe()
        {
            return Ok(recipeSercvice.GetRecipe());
        }

        //Lista - Receita por ID
        [HttpGet("{id}")]
        public IActionResult GetRecipeId(int id)
        {
            if (recipeSercvice.GetRecipeId(id) == null) return BadRequest($"O ID:{id} não existe");
            return Ok(recipeSercvice.GetRecipeId(id));
        }

        //Lista - Receita por Utilizador
        [HttpGet("recipesuser/{id}")]
        public IActionResult GetRecipeUser(int id)
        {

            if (userService.ObterUtilizadorID(id) == null) return BadRequest($"O ID:{id} não existe");
            return Ok(recipeSercvice.GetRecipeUser(id));

        }

        //Lista - Receitas para Validar
        [HttpGet("validate")]
        public IActionResult GetRecipeValidation()
        {
            return Ok(recipeSercvice.GetRecipeValidation());
        }


        // Lista - Pesquisar receita
        [HttpGet("searchname/{name}")]
        public IActionResult GetName(string name)
        {
            if (recipeSercvice.GetName(name).Count == 0) return Ok();
            return Ok(recipeSercvice.GetName(name));
        }


        //Lista - Ordenar por categoria
        [HttpGet("orderby/{id}")]
        public IActionResult GetOrderby(int id)
        {
            if (categoryService.GetCategoryID(id) == null && id !=0 ) return BadRequest($"O ID:{id} não existe");
            return Ok(recipeSercvice.GetOrderby(id));
        }

        //Lista - Ordernar por estado da receita (por utilizador)
        [HttpGet("orderbystate/{iduser}/{idstate}")]
        public IActionResult GetOrderbyState(int iduser, int idstate)
        {
            if (userService.ObterUtilizadorID(iduser) == null) return BadRequest($"Existem ID's inválidos");
            return Ok(recipeSercvice.GetOrderbyState(iduser, idstate));
        }

        //First - Receita para editar
        [HttpGet("editrecipe/{id}")]
        public IActionResult GetRecipeEdit(int id)
        {
            if (recipeSercvice.GetRecipeId(id) == null) return BadRequest($"O ID:{id} não existe");
            return Ok(recipeSercvice.GetRecipeEdit(id));
        }

        // Adicionar receita
        [HttpPost("addrecipe")]
        public IActionResult AddRecipe(Recipe recipe)
        {
            var addrecipe = recipeSercvice.AddRecipe(recipe);

            if (addrecipe == null) return BadRequest("Erro a adicionar a receita - Existem ID's Incorretos");
            return Ok(addrecipe);
        }

        //Editar receita
        [HttpPut("updaterecipe")]
        public IActionResult UpdateRecipe(Recipe recipe)
        {
            var updaterecipe = recipeSercvice.UpdateRecipe(recipe);

            if (updaterecipe == null) return BadRequest("Erro a editar a receita - Existem ID's Incorretos");
            return Ok(updaterecipe);
        }


        [HttpPost("upload")]
        public IActionResult Upload([FromForm] FileUpload objectFile)
        {
            try
            {
                if (objectFile.files.Length > 0)
                {
                    string path = _environment.WebRootPath + "\\recipeimage\\";
                    if (!Directory.Exists(path)) { 
                        Directory.CreateDirectory(path);
                    }

                    using (FileStream fileStream = System.IO.File.Create(path + objectFile.files.FileName)) 
                    { 
                        objectFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return Ok();
                    }
                } else
                {
                    return BadRequest("Não foi feito o upload da imagem da receita");
                }
                
            }
            catch (Exception ex)
            {
              return BadRequest();
            }
               
           

        }

        [HttpGet("getimage/{filename}")]
        public IActionResult Get(string filename)
        {
            try
            {
                var image = System.IO.File.OpenRead(_environment.WebRootPath + "\\recipeimage\\" + filename);
                return File(image, "image/jpeg");
            }
            catch (Exception ex)
            {
                return BadRequest("A imagem da receita não existe");
            }

        }

        //Validar Receita - Admin
        [HttpPut("va")]
        public IActionResult ValidateRecipe(RecipeModel recipe)
        {
            var u = recipeSercvice.ValidateRecipe(recipe);

            if (u == null)
            {
                return NotFound();
            }
            return Ok(u);
        }

       

        

     
    }
}
