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

namespace ToDoList2.View
{
    public partial class AdminView : Form
    {
        LoginController loginController = new LoginController();
        CRUDController crudController = new CRUDController();
        public AdminView()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = adminDataGridView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            RegisterTable reg = new RegisterTable();
            reg.username = txtBoxUsrnm.Text;
            reg.password = txtBoxPass.Text;
            reg.email = txtBoxEmail.Text;
            crudController.UpdateUser(id, reg);
            adminDataGridView.DataSource = crudController.GetAll();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = adminDataGridView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            crudController.DelateUser(id);
            adminDataGridView.DataSource = crudController.GetAll();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            adminDataGridView.DataSource = crudController.GetAll();
        }

        private void btn2Add_Click(object sender, EventArgs e)
        {
            RegisterTable register = new RegisterTable();
            register.username = txtBoxUsrnm.Text;
            register.password = txtBoxPass.Text;    
            register.email = txtBoxEmail.Text;
            crudController.AddUser(register);
            adminDataGridView.DataSource = crudController.ShowAllUsers();
        }
    }
}
