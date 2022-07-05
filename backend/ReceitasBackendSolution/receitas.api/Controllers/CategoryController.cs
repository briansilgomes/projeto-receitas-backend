using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;

namespace receitas.api.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService categorySercvice;
        public CategoryController(ICategoryService u)
        {
            categorySercvice = u;
        }

        //Lista - Categorias
        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(categorySercvice.GetCategory());
        }
    }
}
