using receitas.entidades;

namespace receitas.api.Services
{
    public interface IRecipeService
    {
        List<RecipeModel> GetRecipe();
        List<RecipeModel> GetRecipeValidation();
        List<RecipeModel> GetRecipeUser(int id);
        List<RecipeModel> GetOrderby(int id);
        List<RecipeModel> GetOrderbyState(int iduser, int idstate);
        
        Recipe AddRecipe(Recipe recipe);
        Recipe UpdateRecipe(Recipe recipe);

        List<RecipeModel> GetName(string name);

        Recipe GetRecipeEdit(int id);


        RecipeModel GetRecipeId(int id);
        RecipeModel ValidateRecipe(RecipeModel recipe);
    }
}
