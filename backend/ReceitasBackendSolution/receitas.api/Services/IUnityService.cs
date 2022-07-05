using receitas.entidades;

namespace receitas.api.Services
{
    public interface IUnityService
    {
        List<Unity> GetUnity();
        List<Unity> GetSearch(string search);
        Unity GetDetail(int id);
        Unity AddUnity(Unity unity);
        Unity UpdateUnity(Unity unity);
        Unity ValidateUnity(Unity unity);
    }
}
