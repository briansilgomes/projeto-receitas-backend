using receitas.entidades;

namespace receitas.api.Services
{
    public interface IFavoriteService
    {
        List<RecipeModel> GetFavorite(int id);
        Favorite AddFavorite(Favorite favorite);
        Favorite RemoveFavorite(int id);
        Favorite ValidateFavoriteUser(int idreceita, int iduser);
    }
}
