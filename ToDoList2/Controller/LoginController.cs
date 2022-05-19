using System.Collections.Generic;
using System.Linq;
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
                        return "Wrong Password!";
                    }
                }
                return isLogged;
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
                user.Id = users.ToString().LastOrDefault() + 1;
                log.RegisterTables.Add(user);
                log.SaveChanges();
            }
        }   
    }
}
