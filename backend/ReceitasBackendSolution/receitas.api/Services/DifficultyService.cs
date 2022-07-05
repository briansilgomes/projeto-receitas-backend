using receitas.entidades;
using receitas.api.Data;

namespace receitas.api.Services
{
    public class DifficultyService : IDifficultyService
    {
        IDifficultyDao difficultyDao;
        public DifficultyService(IDifficultyDao dao)
        {
            difficultyDao = dao;
        }

        public List<Difficulty> GetDifficulty()
        {
            return difficultyDao.GetDifficulty();
        }
    }
}
