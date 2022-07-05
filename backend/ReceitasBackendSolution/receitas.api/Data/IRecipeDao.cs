using receitas.entidades;
namespace receitas.api.Data
{
    public interface IRecipeDao
    {
       List<RecipeModel> GetRecipe();
       List<RecipeModel> GetRecipeValidation();
       List<RecipeModel> GetRecipeUser(int id);
       List<RecipeModel> GetOrderby(int id);
       List<RecipeModel> GetName(string name);
       List<RecipeModel> GetOrderbyState(int iduser, int idstate);

       Recipe GetRecipeEdit (int id);

       Recipe AddRecipe(Recipe recipe);
       Recipe UpdateRecipe(Recipe recipe);

       RecipeModel GetRecipeId(int id);
       RecipeModel ValidateRecipe(RecipeModel recipe);
    }
}
