using receitas.entidades;

namespace receitas.api.Data
{
    public interface IUnityDao
    {
        List<Unity> GetUnity();
        List<Unity> GetSearch(string search);
        Unity GetDetail(int id);
        Unity AddUnity(Unity unity);
        Unity UpdateUnity(Unity unity);
        Unity ValidateUnity(Unity unity);

    }
}
 