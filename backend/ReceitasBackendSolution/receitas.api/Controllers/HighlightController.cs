using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
    [Route("api/highlight")]
    [ApiController]
    public class HighlightController : ControllerBase
    {

        IHighlightServcie highlightService;
        public HighlightController(IHighlightServcie u)
        {
            highlightService = u;
        }

        //Lista - Destaques
        [HttpGet]
        public IActionResult GetRecipeHighlight()
        {
            return Ok(highlightService.GetRecipeHighlight());
        }

        //Lista - Ingredientes + destaques
        [HttpGet("admhighlight")]
        public IActionResult GetAdmRecipeHighlights()
        {
            return Ok(highlightService.GetAdmRecipeHighlights());
        }

        //Adicionar - Destaque
        [HttpPost]
        public IActionResult AddRecipeHighlight(Highlight highlight)
        {

            if (highlightService.AddRecipeHighlight(highlight) == null) return BadRequest($"O ID:{highlight.Idrecipe} não existe ou já foi adicionado aos destaques");
            return Ok();
        }

        //Remover - Destaque
        [HttpDelete("{id}")]
        public IActionResult DeleteRecipeHighlight(int id)
        {

            if (highlightService.DeleteRecipeHighlight(id) == null) return BadRequest($"O ID:{id} não existe nos destaques");
            return Ok();

        }
    }
}
