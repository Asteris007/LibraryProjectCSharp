using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LibraryProject
{
    public partial class AllVisitorsWhoAreLateOrNotReturn : Form
    {
        Connection connection = new Connection();

        public AllVisitorsWhoAreLateOrNotReturn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Readers.FirstName, Readers.LastName, Borrow.BorrowDate, Borrow.ReturnDate, Books.Title " +
                 "FROM Borrow " +
                 "INNER JOIN Readers ON Borrow.ReaderID = Readers.ReaderID " +
                 "INNER JOIN Books ON Borrow.BookID = Books.BookID " +
            "WHERE Borrow.ReturnDate < GETDATE() AND Borrow.ReturnBook = 0";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewAVLR.DataSource = ds.Tables[0];
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            new MenuPageForm().Show();
            this.Hide();
        }

        private void butQue_Click(object sender, EventArgs e)
        {
            new QueriesForm().Show();
            this.Hide();
        }
    }
}
