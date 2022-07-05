using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;

namespace receitas.api.Controllers
{
    [Route("api/state")]
    [ApiController]
    public class StateController : Controller
    {
        IStateService stateSercvice;
        public StateController(IStateService u)
        {
            stateSercvice = u;
        }

        public IActionResult GetSates()
        {
            return Ok(stateSercvice.GetStates());
        }
    }
}
