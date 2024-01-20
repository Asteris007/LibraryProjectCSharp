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
    public partial class MenuPageForm : Form
    {
        public MenuPageForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           new ReadersForm().Show();
            this.Hide();
        }

       

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            new BooksForm().Show();
            this.Hide();
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            new BorrowForm().Show();
            this.Hide();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {

        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            new AdminMenuForm().Show(); 
            this.Hide();
        }
    }
}
