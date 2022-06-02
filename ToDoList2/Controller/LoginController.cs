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
        public List<RegisterTable> GetAll()
        {
            using(RegisterDBEntities db = new RegisterDBEntities())
            {
                return db.RegisterTables.ToList();
            }
        }
        public List<RegisterTable> ShowAllUsers()
        {
            using(RegisterDBEntities user = new RegisterDBEntities())
            {
                var users = user.RegisterTables.ToList();
                return users;
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
        public void UpdateUser(int id, RegisterTable register)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                var updateUser = log.RegisterTables.Where(u => u.Id == id).FirstOrDefault();
                if (updateUser != null)
                {
                    updateUser.Id = id;
                    updateUser.username = register.username;
                    updateUser.password = register.password;
                    updateUser.email = register.email;
                    log.SaveChanges();
                }
            }
        }
        public void DelateUser(int id)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                var delateUser = log.RegisterTables.Where(u => u.Id == id).FirstOrDefault();
                if (delateUser != null)
                {
                    log.RegisterTables.Remove(delateUser);
                    log.SaveChanges();
                }
            }
        }

    }
}
