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

namespace ToDoList2.View
{
    public partial class RegisterView : Form
    {
        LoginController loginController = new LoginController();
        public RegisterView()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (true)
            {
                loginController.Register(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                MessageBox.Show("Account succsessfully created!");
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginView().ShowDialog();
            this.Close();
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
