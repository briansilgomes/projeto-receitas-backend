using receitas.api.Data;
using receitas.entidades;
namespace receitas.api.Services
{
    public class RecipeService: IRecipeService
    {

        IRecipeDao recipeDao;
        public RecipeService(IRecipeDao dao)
        {
            recipeDao = dao;
        }

        public List<RecipeModel> GetRecipe()
        {
            return recipeDao.GetRecipe();
        }

        public List<RecipeModel> GetRecipeValidation()
        {
            return recipeDao.GetRecipeValidation();
        }

        public List<RecipeModel> GetRecipeUser(int id)
        {
            return recipeDao.GetRecipeUser(id);
        }

        public RecipeModel GetRecipeId(int id)
        {
            return recipeDao.GetRecipeId(id);
        }

        public RecipeModel ValidateRecipe(RecipeModel recipe)
        {
           return recipeDao.ValidateRecipe(recipe);
        }

        public List<RecipeModel> GetOrderby(int id)
        {
            return recipeDao.GetOrderby(id);
        }

        public List<RecipeModel> GetName(string name)
        {
         return recipeDao.GetName(name);
        }

        public List<RecipeModel> GetOrderbyState(int iduser, int idstate)
        {
            return recipeDao.GetOrderbyState(iduser, idstate);
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            return recipeDao.AddRecipe(recipe);
        }

        public Recipe GetRecipeEdit(int id)
        {
           return recipeDao.GetRecipeEdit(id);
        }

        public Recipe UpdateRecipe(Recipe recipe)
        {
            return recipeDao.UpdateRecipe(recipe);
        }
    }
}
