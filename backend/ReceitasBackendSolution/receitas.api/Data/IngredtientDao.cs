using receitas.entidades;
namespace receitas.api.Data
{
    public class IngredtientDao : IIngredientDao
    {
        ReceitasDbContext receitasdb;
        public IngredtientDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        // List de Ingredientes
        public List<Ingredient> GetIngredient()
        {
            var result = (from ingre in receitasdb.Ingredientes
                          orderby ingre.Nameingredient
                          select ingre).ToList();
            return result;
        }

        // List - Ingrediente por ID
        public Ingredient GetDetail(int id)
        {
            try
         {
                return receitasdb.Ingredientes.First<Ingredient>(ingredient => ingredient.Idingredient == id);
            } catch (Exception ex)
            {
                return null;
            }
      
        }

        // List - Ingredientes da Receita
        public List<RecipeIngredientModel> GetRecipeIngredient(int id)
        {

            return (from recipeingredient in receitasdb.ReceitaIngredientes

                    join unity in receitasdb.Unidade
                    on recipeingredient.Idunity equals unity.Idunity

                    join ingredient in receitasdb.Ingredientes
                    on recipeingredient.Idingredient equals ingredient.Idingredient


                    where recipeingredient.Idrecipe == id

                    select new RecipeIngredientModel
                    {
                        Idingredientrecipe = recipeingredient.Idingredientrecipe,
                        Quantityingredient = recipeingredient.Quantityingredient,

                        Nameingredient = ingredient.Nameingredient,
                        Nameunity = unity.Nameunity,
                        Siglaunity = unity.Siglaunity,


                    }).ToList();

        }

        //Result - Search 
        public List<Ingredient> ResultSearch(string search)
        {
           
            return (from ingredient in receitasdb.Ingredientes
                    where ingredient.Nameingredient.Contains(search)
                    select ingredient).ToList();

        }

        //Adicionar Ingrediente
        public Ingredient AddIngredient(Ingredient ingre)
        {

            receitasdb.Ingredientes.Add(ingre);
            receitasdb.SaveChanges();

            return ingre;

        }

        // Alterar Ingrediente
        public Ingredient UpdateIngredient(Ingredient ingre)
        {

            var exitexistingIngredient = receitasdb.Ingredientes.Where(data => data.Idingredient == ingre.Idingredient).FirstOrDefault<Ingredient>(); 

            if (exitexistingIngredient != null)
            {
                exitexistingIngredient.Nameingredient = ingre.Nameingredient.Trim();
                receitasdb.SaveChanges();

            }

            return exitexistingIngredient;

        }

        // Validar Ingredeinte
        public Ingredient ValidateIngredient(Ingredient ingre)
        {
           

            var exitexistingIngredient = receitasdb.Ingredientes.Where(data => data.Nameingredient == ingre.Nameingredient).FirstOrDefault<Ingredient>();


            return exitexistingIngredient;

        }

        
    }
}
