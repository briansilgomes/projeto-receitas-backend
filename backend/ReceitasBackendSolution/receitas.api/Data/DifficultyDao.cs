using receitas.entidades;

namespace receitas.api.Data
{
    public class DifficultyDao : IDifficultyDao
    {
        ReceitasDbContext receitasdb;
        public DifficultyDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public List<Difficulty> GetDifficulty()
        {
            return receitasdb.Dificuldade.ToList();
        }
    }
}
