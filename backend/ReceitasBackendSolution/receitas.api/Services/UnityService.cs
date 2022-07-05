using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{
    public class UnityService : IUnityService
    {
        IUnityDao unityDao;
        public UnityService(IUnityDao dao)
        {
            unityDao = dao;
        }


        public List<Unity> GetUnity()
        {
           return unityDao.GetUnity();
        }

        public Unity GetDetail(int id)
        {
            return unityDao.GetDetail(id);
        }

        public Unity AddUnity(Unity unity)
        {
            return unityDao.AddUnity(unity);
        }

        public Unity UpdateUnity(Unity unity)
        {
            return unityDao.UpdateUnity(unity);
        }

        public Unity ValidateUnity(Unity unity)
        {
            return unityDao.ValidateUnity(unity);
        }

        public List<Unity> GetSearch(string search)
        {
            return unityDao.GetSearch(search);
        }
    }
}
