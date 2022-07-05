using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;

namespace receitas.api.Controllers
{
    [Route("api/difficulty")]
    [ApiController]
    public class DifficultyController : ControllerBase
    {
        IDifficultyService difficultySercvice;
        public DifficultyController(IDifficultyService u)
        {
            difficultySercvice = u;
        }

        //List - Dificuldade
        [HttpGet]
        public IActionResult GetCommenGetDifficultyt()
        {
         
            return Ok(difficultySercvice.GetDifficulty());

        }

    }
}
