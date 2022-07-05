using receitas.entidades;

namespace receitas.api.Data
{
    public class CategoryDao: ICategoryDao
    {
        ReceitasDbContext receitasdb;
        public CategoryDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public IEnumerable<Category> GetCategory()
        {
            return receitasdb.Categorias.ToList();
        }

        public Category GetCategoryID(int id) 
        {
     
            return receitasdb.Categorias.Where(highlight => highlight.Idcategory == id).FirstOrDefault();

        }
    }
}
