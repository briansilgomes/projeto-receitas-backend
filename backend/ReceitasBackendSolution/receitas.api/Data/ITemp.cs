using receitas.entidades;

namespace receitas.api.Data
{
    public interface ITemp
    {
        Temp AddTemporary(Temp temp);
        Temp RemoveTemporary(int idtemp);
        Temp SendTempReal(int idrecipe, int user);
        List<TempModel> GetTemporary(int iduser);
        Temp RemoveAll(int iduser);
        Temp SendRealTemp(int idrecipe, int iduser);

        RecipeIngredient RemoveAllReal(int idrecipe);
    }
}
