using receitas.entidades;

namespace receitas.api.Data
{
    public interface IUserDao
    {
        List<UserModel> GetUser();
        List<UserModel> GetSearch(string search);

        User ObterUtilizadorID(int iduser);
        User LookUser(UserModel user);
        User UnLookUser(UserModel user);
        User AddUser(User user);
        User EditUser(User user);
        UserModel UserHome(int iduser);
        User Login(LoginTo login);
        UserModel ObterUsername(string username);



       
    }
}
