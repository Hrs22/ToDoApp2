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
            var password = loginController.IsUserLogged(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            var adminPassword = loginController.IsUserAdmin(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            if (password)
            {
                MessageBox.Show("Succsesfully logged!");
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();

            }
            else if (adminPassword)
            {
                MessageBox.Show("Succsesfully logged into Admin!");
                AdminView mv = new AdminView();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
            else
            {
                
            }
           // if (txtbox1.Text == "" && txtbox2.Text == "" && txtBox3.Text == "")
          //  {
          //      MessageBox.Show("Fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
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
    }
}
