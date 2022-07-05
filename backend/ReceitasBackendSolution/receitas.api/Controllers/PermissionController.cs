using Microsoft.AspNetCore.Mvc;
using receitas.api.Services;

namespace receitas.api.Controllers
{
    [Route("api/permission")]
    [ApiController]
    public class PermissionController : Controller
    {
        IPermissionService permissionSercvice;
        public PermissionController(IPermissionService permission)
        {
            permissionSercvice = permission;
       
        }

        [HttpGet]
        public IActionResult GetPermission()
        {
            return Ok(permissionSercvice.GetPermissions());
        }
    }
}
