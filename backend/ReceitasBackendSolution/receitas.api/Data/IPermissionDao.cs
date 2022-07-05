using receitas.entidades;

namespace receitas.api.Data
{
    public interface IPermissionDao
    {
        List<Permission> GetPermissions();
    }
}
