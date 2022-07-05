using receitas.entidades;

namespace receitas.api.Data
{
    public class FavoriteDao : IFavoriteDao
    {
        ReceitasDbContext receitasdb;
        public FavoriteDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public List<RecipeModel> GetFavorite(int id)
        {
            var result = (from favorite in receitasdb.Favoritos
                          join recipe in receitasdb.Receitas
                          on favorite.Idrecipe equals recipe.Idrecipe

                          join category in receitasdb.Categorias
                          on recipe.Idcategory equals category.Idcategory
                         

                          where favorite.Iduser == id


                          select new RecipeModel
                          {
                              Idrecipe = recipe.Idrecipe,
                              favorite = favorite.Idfavorite,
                              Namerecipe = recipe.Namerecipe,
                              Imagerecipe = "http://localhost:5101/api/recipes/getimage/" + recipe.Imagerecipe,
                              Categoryname = category.Namecategory,
                          }
                          ).ToList();

            return result.ToList();
        }

        public Favorite AddFavorite(Favorite favorite)
        {
            receitasdb.Favoritos.Add(favorite);
            receitasdb.SaveChanges();
            
            return favorite;
        }

        public Favorite RemoveFavorite(int id)
        {

            var result = receitasdb.Favoritos
                .Where(favorite => favorite.Idfavorite == id).FirstOrDefault();

            try
            {
                receitasdb.Favoritos.Remove(result);
                receitasdb.SaveChanges();
                return result;
            }   catch (Exception ex)
            {
                return null;
            }


           
        }

        public Favorite ValidateFavoriteUser(int idreceita, int iduser)
        {

            var result = receitasdb.Favoritos
              .Where(favorite => favorite.Idrecipe == idreceita && favorite.Iduser==iduser).FirstOrDefault();

            return result;
        }
    }
}
