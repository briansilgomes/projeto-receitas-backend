using receitas.entidades;

namespace receitas.api.Data
{
    public interface IIngredientDao
    {
        List<Ingredient> GetIngredient();
        List<Ingredient> ResultSearch(string search);
        Ingredient GetDetail(int id);
        Ingredient AddIngredient(Ingredient ingre);
        Ingredient UpdateIngredient(Ingredient ingre);
        Ingredient ValidateIngredient(Ingredient ingre);
        List<RecipeIngredientModel> GetRecipeIngredient(int id);
        
    }
}
