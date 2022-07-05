using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{

    public class PermissionService : IPermissionService
    {
        IPermissionDao permissionDao;
        public PermissionService(IPermissionDao dao)
        {
            permissionDao = dao;
        }

        public List<Permission> GetPermissions()
        {
            return permissionDao.GetPermissions();
        }
    }
}
