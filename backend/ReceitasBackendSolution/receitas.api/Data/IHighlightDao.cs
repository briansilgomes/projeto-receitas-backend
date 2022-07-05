using receitas.entidades;

namespace receitas.api.Data
{
    public interface IHighlightDao
    {

        List<HighlightModel> GetRecipeHighlight();
        List<RecipeModel> GetAdmRecipeHighlights();
        Highlight AddRecipeHighlight(Highlight highlight);
        Highlight DeleteRecipeHighlight(int id);
    }
}
