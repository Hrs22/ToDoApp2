using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ToDoList2.Controller;

namespace ToDoList2.View
{
    public partial class LoginView : Form
    {
        LoginController loginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            var adminPassword = loginController.IsUserAdmin(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            var message = loginController.IsUserLogged(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            if (adminPassword)
            {
                MessageBox.Show("Succsesfully logged into Admin!");
                AdminView mv = new AdminView();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
            else if (message == null)
            {
                MessageBox.Show("Succsesfully logged!");
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void chkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RegisterView rg = new RegisterView();
            this.Hide();
            rg.ShowDialog();
            this.Close();
        }
    }
}
