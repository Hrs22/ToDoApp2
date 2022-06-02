using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList2.Model;

namespace ToDoList2.Controller
{
    internal class CRUDController
    {
        public List<RegisterTable> GetAll()
        {
            using (RegisterDBEntities db = new RegisterDBEntities())
            {
                return db.RegisterTables.ToList();
            }
        }
        public List<RegisterTable> ShowAllUsers()
        {
            using (RegisterDBEntities user = new RegisterDBEntities())
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
        public void AddUser(RegisterTable reg)
        {
            using(RegisterDBEntities log = new RegisterDBEntities())
            {
                reg.Id = log.RegisterTables.ToList().LastOrDefault().Id + 1;
                log.RegisterTables.Add(reg);
                log.SaveChanges();
            }
        }
    }
}
