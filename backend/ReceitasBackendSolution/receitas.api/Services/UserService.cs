using receitas.api.Data;
using receitas.entidades;

namespace receitas.api.Services
{
    public class UserService:IUserService
    {
        IUserDao userDao;
        public UserService(IUserDao dao)
        {
            userDao = dao;
        }

        public List<UserModel> GetUser()
        {
          return userDao.GetUser();
        }

        public User LookUser(UserModel user)
        {
            return userDao.LookUser(user);
        }

        public User UnLookUser(UserModel user)
        {
            return userDao.UnLookUser(user);
        }

        public User AddUser(User user)
        {
            return userDao.AddUser(user);

        }






        public User ObterUtilizadorID(int iduser)
        {
           return userDao.ObterUtilizadorID(iduser);
        }

        public UserModel ObterUsername(string username)
        {
            return userDao.ObterUsername(username);
        }



        public User Login(LoginTo login)
        {
            return userDao.Login(login);
        }

        public List<UserModel> GetSearch(string search)
        {
            return userDao.GetSearch(search);
        }

        public User EditUser(User user)
        {
            return userDao.EditUser(user);
        }

        public UserModel UserHome(int iduser)
        {
            return userDao.UserHome(iduser);
        }
    }
}
