using receitas.entidades;

namespace receitas.api.Data
{
    public class StateDao : IStateDao
    {
        ReceitasDbContext receitasdb;
        public StateDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public List<State> GetStates()
        {
            var result =  receitasdb.State.Where(temp => temp.Idstate == 1 ).ToList();
            result.Add(receitasdb.State.Where(temp => temp.Idstate == 8).FirstOrDefault());

            
       

            return result;
        }
    }
}
