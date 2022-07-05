using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{
    public class TempService : ITempService
    {

        ITemp tempDao;
        public TempService(ITemp dao)
        {
            tempDao = dao;
        }

        public Temp AddTemporary(Temp temp)
        {
            return tempDao.AddTemporary(temp);
        }

        public List<TempModel> GetTemporary(int iduser)
        {
            return tempDao.GetTemporary(iduser);
        }

        public Temp RemoveAll(int iduser)
        {
            return tempDao.RemoveAll(iduser);
        }

        public RecipeIngredient RemoveAllReal(int idrecipe)
        {
            return tempDao.RemoveAllReal(idrecipe);
        }

        public Temp RemoveTemporary(int idtemp)
        {
         return tempDao.RemoveTemporary(idtemp);
        }

        public Temp SendRealTemp(int idrecipe, int iduser)
        {
            return tempDao.SendRealTemp(idrecipe, iduser);
        }

        public Temp SendTempReal(int idrecipe, int user)
        {
           return tempDao.SendTempReal(idrecipe, user);
        }
    }
}
