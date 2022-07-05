using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;
using receitas.entidades;

namespace receitas.api.Controllers
{
   
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        IUserService utilizadoresService;
        public UserController( IUserService us)
        {
            utilizadoresService = us;
        }

        //List - Todos os Utilizadores
        [HttpGet]
        public IActionResult GetUser()
        {

            var u = utilizadoresService.GetUser();

            if (u == null)
            {
                return NotFound();
            }
            return Ok(u);
        }

        //Pesquisa Utilizador
        [HttpGet("search/{search}")]
        public IActionResult Search (string search)
        {
            return Ok(utilizadoresService.GetSearch(search));
        }

        //Pesquisa por Email
        [HttpGet("{username}")]
        public IActionResult ObterUtilizadorUsername(string username)
        {
            return Ok(utilizadoresService.ObterUsername(username));
        }

        //Pesquisa por ID
        [HttpGet("id/{iduser}")]
        public IActionResult ObterUtilizadorID(int iduser)
        {
            return Ok(utilizadoresService.ObterUtilizadorID(iduser));
        }
       
        //Adicionar Utilizador
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            //if(utilizadoresService.ObterUsername(user.Emailuser)!= null)return BadRequest("Utilizador já existe");
            return Ok(utilizadoresService.AddUser(user));
        }

        //Editar Utilizador
        [HttpPut]
        public IActionResult EditUser(User user)
        {
            if(utilizadoresService.ObterUtilizadorID(user.Iduser)== null)return BadRequest($"O ID:{user.Iduser} não é valido");
            return Ok(utilizadoresService.EditUser(user));
        }


      
        //Home - Utilizador
        [HttpGet("userhome/{iduser}")]
        public IActionResult ObterHome(int iduser)
        {
            return Ok(utilizadoresService.UserHome(iduser));
        }

        //Bloquear Utilizador
        [HttpPut("look")]
        public IActionResult LookUser(UserModel user)
        {
            if (utilizadoresService.ObterUtilizadorID(user.Iduser) == null) { return BadRequest("O utilizador não existe."); };
            utilizadoresService.LookUser(user);
            return Ok();
        }

        //Desbloquear Utilizador
        [HttpPut("unlook")]
        public IActionResult UnLookUser(UserModel user)
        {
            if (utilizadoresService.ObterUtilizadorID(user.Iduser) == null) { return BadRequest("O utilizador não existe."); };
            utilizadoresService.UnLookUser(user);
            return Ok();
        }


        [HttpPost("login")]
        public IActionResult Login(LoginTo login)
        {

            var u = utilizadoresService.Login(login);

            if (u == null)
            {
                return Unauthorized();
            }
            return Ok(u);

        }
    }
}
