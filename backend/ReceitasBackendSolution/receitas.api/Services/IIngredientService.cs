using receitas.entidades;

namespace receitas.api.Services

{
    public interface IIngredientSercvice
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
