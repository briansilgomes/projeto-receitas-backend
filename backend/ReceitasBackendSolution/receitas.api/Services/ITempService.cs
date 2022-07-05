using receitas.entidades;

namespace receitas.api.Services
{
    public interface ITempService
    {
        Temp AddTemporary(Temp temp);
        Temp RemoveTemporary(int idtemp);
        Temp RemoveAll(int iduser);
        Temp SendTempReal(int idrecipe, int user);
        List<TempModel> GetTemporary(int iduser);
        Temp SendRealTemp(int idrecipe, int iduser);
        RecipeIngredient RemoveAllReal(int idrecipe);
    }
}
