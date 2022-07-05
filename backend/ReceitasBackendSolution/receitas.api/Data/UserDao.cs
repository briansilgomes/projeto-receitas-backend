using receitas.entidades;

namespace receitas.api.Data
{
    public class UserDao:IUserDao
    {
        ReceitasDbContext receitasdb;
        public UserDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public User ObterUtilizadorID (int iduser)
        {

            var result = (from user in receitasdb.Utilizadores
  
                          where user.Iduser == iduser

                          select user ).FirstOrDefault();

           return result;

        }

        public User LookUser(UserModel user)
        {
            var userexist = receitasdb.Utilizadores.Where(data => data.Iduser == user.Iduser).FirstOrDefault<User>();

            if (userexist != null)
            {
                userexist.Idstate = 1;
                receitasdb.SaveChanges();

            }

            return userexist;

        }

        public UserModel ObterUsername (string username)
        {
            var result = (from user in receitasdb.Utilizadores
                          join state in receitasdb.State
                          on user.Idstate equals state.Idstate
                          join permission in receitasdb.Permissao
                         on user.Idpermission equals permission.Idpermission

                          where user.Emailuser == username

                          select new UserModel
                          {
                              Iduser = user.Iduser,
                              Nameuser = user.Nameuser,
                              Emailuser = user.Emailuser,
                              Imageuser = user.Userimage,
                              State = state.NameState,
                              Permission = permission.Namepermission

                          }).FirstOrDefault();

            return result;
        }

        public List<UserModel> GetUser()
        {
            return (from user in receitasdb.Utilizadores
                    join state in receitasdb.State
                          on user.Idstate equals state.Idstate
                          join permission in receitasdb.Permissao
                          on user.Idpermission equals permission.Idpermission
                         
                          select new UserModel
                          {
                              Iduser = user.Iduser,
                              Nameuser = user.Nameuser,
                              Emailuser = user.Emailuser,
                              Imageuser = user.Userimage,
                              State = state.NameState,
                              Permission =  permission.Namepermission
                          }).ToList();

        }

        public User UnLookUser(UserModel user)
        {
            var userexist = receitasdb.Utilizadores.Where(data => data.Iduser == user.Iduser).FirstOrDefault<User>();

            if (userexist != null)
            {
                userexist.Idstate = 8;
                receitasdb.SaveChanges();

            }

            return userexist;
        }

        public User AddUser(User user)
        {
            receitasdb.Utilizadores.Add(user);
            receitasdb.SaveChanges();

            return user;
        }

        public User Login(LoginTo login)
        {
            var user = receitasdb.Utilizadores.FirstOrDefault<User>(user => user.Emailuser == login.Username);

            if (user == null)
            {
                return null;
            }
            if (user.Emailuser == login.Username && user.Passworduser == login.Password)
            {
                return user;
            } else return null;
            

        }

        public List<UserModel> GetSearch(string search)
        {
           return (from user in receitasdb.Utilizadores
                   join state in receitasdb.State
                   on user.Idstate equals state.Idstate

                   where user.Nameuser.Contains(search) || user.Emailuser.Contains(search)
                   select new UserModel
                   {
                       Iduser = user.Iduser,
                       Nameuser = user.Nameuser,
                       Emailuser = user.Emailuser,
                       Imageuser = user.Userimage,
                       State = state.NameState
                   }).ToList();
        }

        public User EditUser(User user)
        {
            var exitUser = receitasdb.Utilizadores.Where(data => data.Iduser == user.Iduser).FirstOrDefault<User>();

            if (exitUser != null)
            {
                exitUser.Nameuser = user.Nameuser.Trim();
                exitUser.Emailuser = user.Emailuser.Trim();
                exitUser.Userimage = user.Userimage.Trim();
                exitUser.Passworduser = user.Passworduser.Trim();
                exitUser.Userimage = user.Userimage.Trim();
                exitUser.Idstate = user.Idstate;
                exitUser.Idpermission = user.Idpermission;

                receitasdb.SaveChanges();

            }

            return exitUser;
        }

        public UserModel UserHome(int iduser)
        {
            var result = (from user in receitasdb.Utilizadores
                          join state in receitasdb.State
                          on user.Idstate equals state.Idstate
                          join permission in receitasdb.Permissao
                         on user.Idpermission equals permission.Idpermission

                          where user.Iduser == iduser

                          select new UserModel
                          {
                              Iduser = user.Iduser,
                              Nameuser = user.Nameuser,
                              Emailuser = user.Emailuser,
                              Imageuser = user.Userimage,
                              State = state.NameState,
                              Permission = permission.Namepermission

                          }).FirstOrDefault();

            return result;
        }
    }
}
