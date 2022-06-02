using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToDoList2.Model;

namespace ToDoList2.Controller
{
    public class LoginController
    {

        public string IsUserLogged(string username, string password, string email)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                string message = null;

                var existingUser = log.RegisterTables.Where(u => u.username == username).FirstOrDefault();
                if (existingUser == null)
                {
                    message = "No such user!";
                }
                else if (existingUser.username != username)
                {
                    message = "Wrong username!";
                }
                else if (existingUser.password != password)
                {
                    message = "Wrong password!";
                }
                else if (existingUser.email != email)
                {
                    message = "Wrong email!";
                }

                return message;
            }
        }
        public bool ShowMessage(string username, string password, string email)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                bool isLogged = false;
                foreach (var user in log.RegisterTables)
                {
                    if (user.username == username && user.password == password && user.email == email)
                    {
                        isLogged = true;
                        GlobalData.CurrentUserId = user.Id;
                    }
                    else
                    {
                        isLogged = false;
                    }
                }
                return isLogged;
            }
        }
        public bool IsUserAdmin(string username, string password, string email)
        {
            bool isLoggedAsAdmin = false;
            if (username == "admin" && password == "admin" && email == "admin@abv.bg")
            {
                isLoggedAsAdmin = true;
            }
            return isLoggedAsAdmin;
        }
    }
}
