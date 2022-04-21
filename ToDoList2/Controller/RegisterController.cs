﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList2.Model;

namespace ToDoList2.Controller
{
    internal class RegisterController
    {
        public List<RegisterTable> GetAll()
        {
            using (RegisterModel model = new RegisterModel())
            {
                return model.RegisterTables.ToList();
            }
        }
        public List<RegisterTable> ShowAll()
        {
            using (RegisterModel reg = new RegisterModel())
            {
                var register = reg.RegisterTables.ToList();
                return register;
            }
        }
        public void CreateRegister(RegisterTable r)
        {
            using (RegisterModel reg = new RegisterModel())
            {
                r.Id = reg.RegisterTables.ToList().LastOrDefault().Id + 1;
                reg.RegisterTables.Add(r);
                reg.SaveChanges();
            }
        }
    }
}
