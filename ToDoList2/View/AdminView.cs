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

        public AdminView()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv1.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            RegisterTable reg = new RegisterTable();
            reg.username = txtBox1.Text;
            reg.password = txtBox1.Text;
            reg.email = txtBox1.Text;
            loginController.UpdateUser(id, reg);
            dgv1.DataSource = loginController.GetAll();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv1.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            loginController.DelateUser(id);
            dgv1.DataSource = loginController.GetAll();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = loginController.GetAll();
        }
    }
}
