using receitas.entidades;

namespace receitas.api.Data
{
    public class TempDao : ITemp
    {
        ReceitasDbContext receitasdb;
        public TempDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public Temp AddTemporary(Temp temp)
        {
            receitasdb.Add(temp);
            receitasdb.SaveChanges();
            return temp;
        }

        public List<TempModel> GetTemporary(int iduser)
        {
            var result = ( from temp in receitasdb.Temporario
                           
                           join ingre in receitasdb.Ingredientes
                           on temp.Idingredient equals ingre.Idingredient

                           join unity in receitasdb.Unidade
                           on temp.Idunity equals unity.Idunity

                           where temp.Iduser == iduser

                           select new TempModel
                           {
                               Idtemp = temp.Idtemp,
                               Quantityingredient = temp.quantity,
                               Nameingredient = ingre.Nameingredient,
                               Nameunity = unity.Nameunity
                               
                           }
                
                
                ).ToList();

            return result;
        }

        // Limpar tabela temporarios
        public Temp RemoveAll(int iduser)
        {
            var result = receitasdb.Temporario.Where(temp => temp.Iduser == iduser).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                receitasdb.Temporario.Remove(result[i]);
                receitasdb.SaveChanges();
            }

            return result.FirstOrDefault();

            }

        // Limpar ingrediente da tabela temporario
        public Temp RemoveTemporary(int idtemp) { 


             var result = receitasdb.Temporario
                .Where(temp => temp.Idtemp == idtemp).FirstOrDefault();

            try
            {
                receitasdb.Temporario.Remove(result);
                receitasdb.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Limpar ingrediente da tabela na Real
        public RecipeIngredient RemoveAllReal(int idrecipe)
        {
            var result = receitasdb.ReceitaIngredientes.Where(temp => temp.Idrecipe == idrecipe).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                receitasdb.ReceitaIngredientes.Remove(result[i]);
                receitasdb.SaveChanges();
            }

            return result.FirstOrDefault();
        }


        public Temp SendTempReal(int idrecipe, int iduser)
        {
            var result = receitasdb.Temporario.Where(temp => temp.Iduser == iduser).ToList();

          

            for (int i = 0; i < result.Count ; i++)
            {
                var recipeingredient = new RecipeIngredient();

                recipeingredient.Idrecipe = idrecipe;
                recipeingredient.Idunity = result[i].Idunity;
                recipeingredient.Idingredient = result[i].Idingredient;
                recipeingredient.Quantityingredient = result[i].quantity;

                receitasdb.ReceitaIngredientes.Add(recipeingredient);
                receitasdb.SaveChanges();

                receitasdb.Temporario.Remove(result[i]);
                receitasdb.SaveChanges();
            }

            return result.FirstOrDefault();


        }

        public Temp SendRealTemp(int idrecipe, int iduser)
        {

            RemoveAll(iduser);

            var result = receitasdb.ReceitaIngredientes.Where(temp => temp.Idrecipe == idrecipe).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                var recipeingredient = new Temp();

                recipeingredient.quantity = result[i].Quantityingredient;
                recipeingredient.Idunity = result[i].Idunity;
                recipeingredient.Idingredient = result[i].Idingredient;
                recipeingredient.Iduser = iduser;


                receitasdb.Temporario.Add(recipeingredient);
                receitasdb.SaveChanges();

            }

            return null;


        }

        
    }
}
