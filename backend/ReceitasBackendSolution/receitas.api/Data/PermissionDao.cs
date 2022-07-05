using receitas.entidades;

namespace receitas.api.Data
{
    public class PermissionDao : IPermissionDao
    {
        ReceitasDbContext receitasdb;
        public PermissionDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }
        public List<Permission> GetPermissions()
        {
           return receitasdb.Permissao.ToList();
        }
    }
}
