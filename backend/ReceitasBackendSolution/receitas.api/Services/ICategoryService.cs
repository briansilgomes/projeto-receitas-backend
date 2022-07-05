using receitas.entidades;

namespace receitas.api.Services
{
    public interface ICategoryService
    {
       IEnumerable <Category> GetCategory();
       Category GetCategoryID(int id);
    }
}
