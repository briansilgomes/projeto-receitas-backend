using receitas.entidades;

namespace receitas.api.Data
{
    public class RecipeDao : IRecipeDao
    {

        ReceitasDbContext receitasdb;
        private readonly IWebHostEnvironment _environment;

        public RecipeDao(ReceitasDbContext db, IWebHostEnvironment environment)
        {
            receitasdb = db;
            _environment = environment;
        }

        //List - Receita
        public List<RecipeModel>  GetRecipe()
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
                      
                          

                         }).ToList();

            return result.ToList();

        }
       
        //List - Receita por ID
        public RecipeModel GetRecipeId(int id)
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
                          where recipe.Idrecipe == id

                          select new RecipeModel
                          {
                              Idrecipe = recipe.Idrecipe,
                              Namerecipe = recipe.Namerecipe,
                              Preparationrecipe = recipe.Preparationrecipe,
                              Durationrecipe = recipe.Durationrecipe,
                              Imagerecipe = "http://localhost:5101/api/recipes/getimage/" + recipe.Imagerecipe,
                              Daterecipe = recipe.Daterecipe,

                              Categoryname = category.Namecategory,
                              Nameuser = user.Nameuser,
                              Namestate = state.NameState,
                              Namedifficulty = difficulty.Namedifficulty,
                              

                          }).FirstOrDefault();

            return result;

        }

        //List - Receita por User
        public List<RecipeModel> GetRecipeUser(int id)
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

                          where recipe.Iduser == id
                          orderby recipe.Idrecipe descending


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
                              Daterecipe = recipe.Daterecipe



                          }).ToList();

            return result.ToList();
        }

        //List - Receitas para validar
        public List<RecipeModel> GetRecipeValidation()
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

                          where recipe.Idstate == 7

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

            return result.ToList();
        }

        //List - Receitas por categoria
        public List<RecipeModel> GetOrderby(int id)
        {

            if (id == 0) return GetRecipe();
            
          
                var result = (from recipe in receitasdb.Receitas
                              join category in receitasdb.Categorias
                              on recipe.Idcategory equals category.Idcategory
                              join user in receitasdb.Utilizadores
                              on recipe.Iduser equals user.Iduser
                              join state in receitasdb.State
                              on recipe.Idstate equals state.Idstate
                              join difficulty in receitasdb.Dificuldade
                              on recipe.Iddifficulty equals difficulty.Iddifficulty


                              where recipe.Idstate == 2 && recipe.Idcategory == id

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

            return result.ToList();



        }

        public List<RecipeModel> GetName(string name)
        {

            if (name == null) return null;
            
            var result = (from recipe in receitasdb.Receitas
                          join category in receitasdb.Categorias
                          on recipe.Idcategory equals category.Idcategory
                          join user in receitasdb.Utilizadores
                          on recipe.Iduser equals user.Iduser
                          join state in receitasdb.State
                          on recipe.Idstate equals state.Idstate
                          join difficulty in receitasdb.Dificuldade
                          on recipe.Iddifficulty equals difficulty.Iddifficulty


                          where recipe.Idstate == 2 && recipe.Namerecipe.Contains(name) || recipe.Idstate == 2 && recipe.Preparationrecipe.Contains(name)
                          
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

            return result.ToList();


        }

        public List<RecipeModel> GetOrderbyState(int iduser, int idstate)
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

                          where recipe.Iduser == iduser && recipe.Idstate == idstate


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
                              Daterecipe = recipe.Daterecipe



                          }).ToList();

            return result.ToList();
        }

        public Recipe GetRecipeEdit(int id)
        {
            var result = (from recipe in receitasdb.Receitas
                          where recipe.Idrecipe == id

                          select new Recipe
                          {
                              Idrecipe = recipe.Idrecipe,
                              Namerecipe = recipe.Namerecipe,
                              Preparationrecipe = recipe.Preparationrecipe,
                              Durationrecipe = recipe.Durationrecipe,
                              Imagerecipe = "http://localhost:5101/api/recipes/getimage/" + recipe.Imagerecipe,
                              Daterecipe = recipe.Daterecipe,

                              Idcategory = recipe.Idcategory,
                              Iduser = recipe.Iduser,
                              Idstate = recipe.Idstate,
                              Iddifficulty = recipe.Iddifficulty,


                          }).FirstOrDefault();

            return result;
        }


     

        public RecipeModel ValidateRecipe(RecipeModel recipe)
        {
            var result = receitasdb.Receitas.Where(data => data.Idrecipe == recipe.Idrecipe).FirstOrDefault<Recipe>();

            if (result != null)
            {
                result.Idstate = 2;
                receitasdb.SaveChanges();

            }

            return recipe;
        }

        
    
        
        public Recipe AddRecipe(Recipe recipe)
        {
            try
            {
                receitasdb.Receitas.Add(recipe);
                receitasdb.SaveChanges();
                return recipe;
            } catch (Exception ex)
            {
                return null;
            }
            
        }


        public Recipe UpdateRecipe (Recipe recipe)
        {

            try
            {
                var existRecipe = receitasdb.Receitas.Where(data => data.Idrecipe == recipe.Idrecipe).FirstOrDefault<Recipe>();

                existRecipe.Namerecipe = recipe.Namerecipe.Trim();
                existRecipe.Idcategory = recipe.Idcategory;
                existRecipe.Iddifficulty = recipe.Iddifficulty;
                existRecipe.Imagerecipe = recipe.Imagerecipe.Trim();
                existRecipe.Durationrecipe = recipe.Durationrecipe.Trim();
                existRecipe.Idstate = recipe.Idstate;
                existRecipe.Preparationrecipe = recipe.Preparationrecipe.Trim();

                receitasdb.SaveChanges();

                return existRecipe;

            } catch(Exception ex)
            {
                return null;
            }
          
        }
        
    }
}
