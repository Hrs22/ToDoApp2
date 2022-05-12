using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2.View
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "" && txtbox2.Text == "" && txtBox3.Text == "")
            {
                MessageBox.Show("Fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (true)
            {
                MessageBox.Show("Account succsessfully created!");
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();

                txtbox1.Text = "";
                txtbox2.Text = "";
                txtBox3.Text = "";
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
                txtbox2.PasswordChar = '\0';
            }
            else
            {
                txtbox2.PasswordChar = '•';
            }   
        }
    }
}
