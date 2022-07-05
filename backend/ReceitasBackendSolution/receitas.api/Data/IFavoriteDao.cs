using receitas.entidades;

namespace receitas.api.Data
{
    public interface IFavoriteDao
    {
        List<RecipeModel> GetFavorite(int id);
        Favorite AddFavorite(Favorite favorite);
        Favorite RemoveFavorite(int id);
        Favorite ValidateFavoriteUser(int idreceita, int iduser);
    }
}
