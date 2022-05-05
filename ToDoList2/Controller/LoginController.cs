using ToDoList2.Model;

namespace ToDoList2.Controller
{
    public class LoginController
    {

        public bool IsUserLogged(string username, string password)
        {
            using(RegisterDBEntities log = new RegisterDBEntities())
            {
                bool isLogged = false;
                foreach (var user in log.RegisterTables)
                {
                    if (user.username == username && user.password == password)
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
