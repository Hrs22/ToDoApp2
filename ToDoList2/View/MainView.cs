using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList2.Controller;
using ToDoList2.Model;

namespace ToDoList2
{
    public partial class MainView : Form
    {
        TasksController taskController = new TasksController();
        public MainView()
        {
            InitializeComponent();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            TaskTable task = new TaskTable();
            task.name = txtBoxTaskName.Text;
            task.description = txtBoxTaskDesc.Text;
            taskController.AddTask(task);
            dataGridView1.DataSource = taskController.GetAll();
        }

        private void btnClearTask_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int id = int.Parse(row.Cells[""].Value.ToString());
            taskController.ClearTask(id);
            dataGridView1.DataSource = taskController.GetAll();
        }
    }
}
