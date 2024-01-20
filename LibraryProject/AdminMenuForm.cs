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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AuthorsForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GenreForm().Show(); 
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new YearForm().Show();
            this.Hide();
        }

        private void butGTM_Click(object sender, EventArgs e)
        {
            new MenuPageForm().Show();
            this.Hide();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new QueriesForm().Show();
            this.Hide();
        }
    }
}
