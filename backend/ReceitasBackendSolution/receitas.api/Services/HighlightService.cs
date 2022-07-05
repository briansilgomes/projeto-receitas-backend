using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{

    public class HighlightService : IHighlightServcie
    {

        IHighlightDao highlightDao;
        public HighlightService(IHighlightDao dao)
        {
            highlightDao = dao;
        }

        public List<HighlightModel> GetRecipeHighlight()
        {
            return highlightDao.GetRecipeHighlight();
        }

        public List<RecipeModel> GetAdmRecipeHighlights()
        {
            return highlightDao.GetAdmRecipeHighlights();
        }

        public Highlight AddRecipeHighlight(Highlight highlight)
        {
            return highlightDao.AddRecipeHighlight(highlight);
        }

        public Highlight DeleteRecipeHighlight(int id)
        {
            return highlightDao.DeleteRecipeHighlight(id);
        }

       
    }
}
