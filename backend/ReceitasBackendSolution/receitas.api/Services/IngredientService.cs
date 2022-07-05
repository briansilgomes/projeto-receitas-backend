using receitas.entidades;
using receitas.api.Data;

namespace receitas.api.Services

{
    public class IngredientService : IIngredientSercvice
    {

        IIngredientDao ingredientDao;
        public IngredientService(IIngredientDao dao)
        {
            ingredientDao = dao;
        }

        public List<Ingredient> GetIngredient()
        {
        
          return ingredientDao.GetIngredient();
        }

        public Ingredient GetDetail(int id)
        {
            return ingredientDao.GetDetail(id);
        }

        public Ingredient AddIngredient(Ingredient ingre)
        {
            return ingredientDao.AddIngredient(ingre);
        }

        public Ingredient UpdateIngredient(Ingredient ingre)
        {
            return ingredientDao.UpdateIngredient(ingre);
        }

        public Ingredient ValidateIngredient(Ingredient ingre)
        {
            return ingredientDao.ValidateIngredient(ingre);
        }

        public List<RecipeIngredientModel> GetRecipeIngredient(int id)
        {
            return ingredientDao.GetRecipeIngredient(id);
        }

        public List<Ingredient> ResultSearch(string search)
        {
            return ingredientDao.ResultSearch(search);
        }
    }
}
