using ToDoList2.Model;

namespace ToDoList2.Controller
{
    public class LoginController
    {

        public bool IsUserLogged(string username, string password, string email)
        {
            using(RegisterDBEntities log = new RegisterDBEntities())
            {
                bool isLogged = false;
                foreach (var user in log.RegisterTables)
                {
                    if (user.username == username && user.password == password && user.email == email)
                    {
                        isLogged = true;
                        GlobalData.CurrentUserId = user.Id;
                    }
                }
                return isLogged;
            }
        }

    }
}
