using receitas.entidades;

namespace receitas.api.Data
{
    public interface ICategoryDao
    {
        IEnumerable<Category> GetCategory();
        Category GetCategoryID(int id);
    }
}
