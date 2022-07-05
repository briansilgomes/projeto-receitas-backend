using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{
    public class CategoryService : ICategoryService
    {

        ICategoryDao categoryDao;
        public CategoryService(ICategoryDao dao)
        {
            categoryDao = dao;
        }

        public IEnumerable <Category> GetCategory()
        {
            return categoryDao.GetCategory();
        }

        public Category GetCategoryID(int id)
        {
            return categoryDao.GetCategoryID(id);
        }
    }
}
