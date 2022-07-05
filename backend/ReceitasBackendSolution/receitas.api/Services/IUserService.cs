using receitas.entidades;

namespace receitas.api.Services

{
    public interface IUserService
    {
        List<UserModel> GetUser();
        List<UserModel> GetSearch(string search);
        User ObterUtilizadorID(int iduser);
        UserModel ObterUsername(string username);
        User LookUser(UserModel user);
        User UnLookUser(UserModel user); 
        User AddUser(User user);
        User EditUser(User user);
        User Login(LoginTo login);

        UserModel UserHome(int iduser);



    }
}
