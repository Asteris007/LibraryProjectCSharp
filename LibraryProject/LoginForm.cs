using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTexbox.Text =="admin"&& passswordTexbox.Text=="123")
            {
                new MenuPageForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorect User Name or Password!");
                usernameTexbox.Clear();
                passswordTexbox.Clear();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
