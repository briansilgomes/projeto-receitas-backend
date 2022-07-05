using receitas.entidades;

namespace receitas.api.Data
{
    public class HighlightDao : IHighlightDao

    {
        ReceitasDbContext receitasdb;
        public HighlightDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

      
        public List<HighlightModel> GetRecipeHighlight()
        {
            var result = (from highlight in receitasdb.Destaques
                          join recipe in receitasdb.Receitas
                          on highlight.Idrecipe equals recipe.Idrecipe


                          join category in receitasdb.Categorias
                          on recipe.Idcategory equals category.Idcategory

                          where highlight.Idrecipe == recipe.Idrecipe
                        
                          select new HighlightModel
                          {
                              Idrecipe = recipe.Idrecipe,
                              Namerecipe = recipe.Namerecipe,
                              Imagerecipe = "http://localhost:5101/api/recipes/getimage/" + recipe.Imagerecipe,
                              Categoryname = category.Namecategory,
                          }
                            ).ToList();

            return result.ToList();
        }

        public Highlight AddRecipeHighlight(Highlight highlight)
        {
            var exitrecipe = receitasdb.Receitas.FirstOrDefault(x => x.Idrecipe == highlight.Idrecipe);

            var result = receitasdb.Destaques.Where(high => high.Idrecipe == highlight.Idrecipe).FirstOrDefault();

            if (result != null)
            {
                return null;
            } else if(exitrecipe == null)
            {
                return null;
            }

            receitasdb.Destaques.Add(highlight);
            receitasdb.SaveChanges();

            return highlight;
        }

        public Highlight DeleteRecipeHighlight(int id)
        {
            var result = receitasdb.Destaques.Where(highlight => highlight.Idrecipe == id).FirstOrDefault();

            if (result != null) {
                receitasdb.Destaques.Remove(result);
                receitasdb.SaveChanges();
            }
           
            return result;
        }


        public List<RecipeModel> GetAdmRecipeHighlights()
        {

            var result = (from recipe in receitasdb.Receitas
                          join category in receitasdb.Categorias
                          on recipe.Idcategory equals category.Idcategory
                          join user in receitasdb.Utilizadores
                          on recipe.Iduser equals user.Iduser
                          join state in receitasdb.State
                          on recipe.Idstate equals state.Idstate
                          join difficulty in receitasdb.Dificuldade
                          on recipe.Iddifficulty equals difficulty.Iddifficulty


                          where recipe.Idstate == 2

                          select new RecipeModel
                          {
                              Idrecipe = recipe.Idrecipe,
                              Namerecipe = recipe.Namerecipe,
                              Preparationrecipe = recipe.Preparationrecipe,
                              Durationrecipe = recipe.Durationrecipe,
                              Imagerecipe = "http://localhost:5101/api/recipes/getimage/" + recipe.Imagerecipe,

                              Categoryname = category.Namecategory,
                              Nameuser = user.Nameuser,
                              Namestate = state.NameState,
                              Namedifficulty = difficulty.Namedifficulty,
                              Daterecipe = recipe.Daterecipe,


                          }).ToList();


            var result1 = (from highlight in receitasdb.Destaques
                          join recipe in receitasdb.Receitas
                          on highlight.Idrecipe equals recipe.Idrecipe


                          join category in receitasdb.Categorias
                          on recipe.Idcategory equals category.Idcategory

                          where highlight.Idrecipe == recipe.Idrecipe


                          select new RecipeModel
                          {
                              Idrecipe = recipe.Idrecipe,
                              Namerecipe = recipe.Namerecipe,
                              Imagerecipe = "http://localhost:5101/api/recipes/getimage/" + recipe.Imagerecipe,
                              Categoryname = category.Namecategory,
                          }
                           ).ToList();



            for (int i = 0; i <= result.Count - 1; i++)
            {
                for (int j = 0; j <= result1.Count -1; j++)
                {
                    if (result[i].Idrecipe == result1[j].Idrecipe)
                    {
                        result[i].Highlight = 1;
                    }
                }



            }



            return result.ToList();


        }
    }
}
