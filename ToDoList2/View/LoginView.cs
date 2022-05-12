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
            var password = loginController.IsUserLogged(txtbox1.Text, txtbox2.Text, txtBox3.Text);
            if (password != null)
            {
                MessageBox.Show("Succsesfully logged!");
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("No such user!");
            }
           // if (txtbox1.Text == "" && txtbox2.Text == "" && txtBox3.Text == "")
          //  {
          //      MessageBox.Show("Fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
        }
    }
}
