using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList2.Model;

namespace ToDoList2.Controller
{
    internal class TasksController
    {
        public List<TaskTable> GetAll()
        {
            using (RegisterDBEntities db = new RegisterDBEntities())
            {
                return db.TaskTables.ToList();
            }
        }
        public void AddTask(TaskTable task)
        {
            using(RegisterDBEntities tsk = new RegisterDBEntities())
            {
                task.Id = tsk.TaskTables.ToList().LastOrDefault().Id + 1;
                tsk.TaskTables.Add(task);
                tsk.SaveChanges();
            }
        }
        public void AddDiscription(TaskTable task)
        {
            using (RegisterDBEntities dsk = new RegisterDBEntities())
            {
                task.Id = dsk.TaskTables.ToList().LastOrDefault().Id + 1;
                dsk.TaskTables.Add(task);
                dsk.SaveChanges();
            }
        }
        public void ClearTask(int id)
        {
            using (RegisterDBEntities log = new RegisterDBEntities())
            {
                var delateTask = log.TaskTables.Where(u => u.Id == id).FirstOrDefault();
                if (delateTask != null)
                {
                    log.TaskTables.Remove(delateTask);
                    log.SaveChanges();
                }
            }
        }
    }
}
