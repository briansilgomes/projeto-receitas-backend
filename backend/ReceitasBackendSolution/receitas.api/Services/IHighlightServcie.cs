using receitas.entidades;

namespace receitas.api.Services
{
    public interface IHighlightServcie
    {
        List<HighlightModel> GetRecipeHighlight();
        List<RecipeModel> GetAdmRecipeHighlights();
        Highlight AddRecipeHighlight(Highlight highlight);
        Highlight DeleteRecipeHighlight(int id);
    }
}
