using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
    [Route("api/unitys")]
    [ApiController]
    public class UnityController : ControllerBase
    {
        IUnityService unitySercvice;
        public UnityController(IUnityService u)
        {
            unitySercvice = u;
        }

        [HttpGet]
        public IActionResult GetUnity()
        {
            return Ok(unitySercvice.GetUnity());
        }

        [HttpGet("{id}")]
        public IActionResult GetDetail(int id)
        {

            var existunity = unitySercvice.GetDetail(id);
            if (existunity == null) return BadRequest($"O ID:{id} não existe");

            return Ok(existunity);
        }
        
        [HttpGet("search/{search}")]
        public IActionResult GetSearch(string search)
        {
            return Ok(unitySercvice.GetSearch(search));
        }

        [HttpPost]
        public IActionResult AddUnity(Unity unity)
        {
            var existUnity = unitySercvice.ValidateUnity(unity);

            if (existUnity != null) return BadRequest("A unidade já existe");

            unitySercvice.AddUnity(unity);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + unity.Idunity, unity);
        }

        [HttpPut]
        public IActionResult UpdateUnity(Unity unity)
        {
            var existunity = unitySercvice.GetDetail(unity.Idunity);
            if (existunity == null) return BadRequest($"O ID:{unity.Idunity} não existe");

            var u = unitySercvice.UpdateUnity(unity);
            return Ok();

        }

        [HttpPost("validate")]
        public IActionResult ValidateUnity(Unity unity)
        {
            var u = unitySercvice.ValidateUnity(unity);
            if (u == null) return Ok();

            return Ok(u);
        }

    }
}
