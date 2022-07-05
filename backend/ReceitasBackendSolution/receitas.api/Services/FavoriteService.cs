using receitas.entidades;
using receitas.api.Data;

namespace receitas.api.Services
{
    public class FavoriteService : IFavoriteService
    {
        IFavoriteDao favoriteDao;
        public FavoriteService(IFavoriteDao dao)
        {
            favoriteDao = dao;
        }

        public Favorite AddFavorite(Favorite favorite)
        {
            return favoriteDao.AddFavorite(favorite);
        }

        public List<RecipeModel> GetFavorite(int id)
        {
           return favoriteDao.GetFavorite(id);  
        }

        public Favorite RemoveFavorite(int id)
        {
            return favoriteDao.RemoveFavorite(id);
        }

        public Favorite ValidateFavoriteUser(int idreceita, int iduser)
        {
            return favoriteDao.ValidateFavoriteUser(idreceita, iduser);
        }
    }
}
