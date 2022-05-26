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
                if (existingUser.username != username)
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
            public bool IsUserAdmin(string username, string password, string email)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                bool isLogged = false;
                if (username == "admin" && password == "admin" && email == "admin@gmail.com")
                {
                    isLogged = true;
                }
                return isLogged;
            }
        }
        public void Register(string username, string password, string email)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                RegisterTable user = new RegisterTable();
                user.username = username;
                user.password = password;
                user.email = email;
                List<RegisterTable> users = log.RegisterTables.ToList();
                user.Id = users.LastOrDefault().Id + 1;
                log.RegisterTables.Add(user);
                log.SaveChanges();
            }
        }   
    }
}
