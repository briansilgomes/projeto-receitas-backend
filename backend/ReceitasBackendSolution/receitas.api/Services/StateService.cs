using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{
    public class StateService : IStateService
    {
        IStateDao stateDao;
        public StateService(IStateDao dao)
        {
            stateDao = dao;
        }

        public List<State> GetStates()
        {
            return stateDao.GetStates();
        }
    }
}
