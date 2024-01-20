using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class BorrowForm : Form
    {
         Connection connection = new Connection();
        private List<Borrow> borrowList = new List<Borrow>();
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            string query = "SELECT Borrow.*, Books.Title, Readers.FirstName, Readers.LastName " +
   "FROM Borrow " +
   "INNER JOIN Books ON Borrow.BookID = Books.BookID " +
   "INNER JOIN Readers ON Borrow.ReaderID = Readers.ReaderID";


            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewBorrowing.DataSource = ds.Tables[0];

                borrowList = ds.Tables[0].AsEnumerable().Select(row => new Borrow()
                {
                    
                        BorrowID= row.Field<int>("BorrowID"),
                        ReaderID = row.Field<int>("ReaderID"),
                        BorrowDate= row.Field<DateTime>("BorrowDate"),
                        ReturnDate= row.Field<DateTime>("ReturnDate"),
                    BookID = row.Field<int>("BookID"),
                    ReturnBook = row.Field<bool?>("ReturnBook") ?? false,


                }).ToList();
            }
        
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow
            {
                BorrowID = int.Parse(textBorrowID.Text),
                ReaderID = int.Parse(textReaderID.Text),
                BorrowDate = DateTime.Parse(textBorrowDate.Text),
                ReturnDate = DateTime.Parse(textReturnDate.Text),
                BookID = int.Parse(textBookID.Text)
            };

            connection.Save(borrow);
            DisplayData();
            MessageBox.Show("Data Saved");
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow
            {
                BorrowID = int.Parse(textBorrowID.Text),
                ReaderID = int.Parse(textReaderID.Text),
                BorrowDate = DateTime.Parse(textBorrowDate.Text),
                ReturnDate = DateTime.Parse(textReturnDate.Text),
                BookID = int.Parse(textBookID.Text)
            };

            connection.Update(borrow);
            DisplayData();
            MessageBox.Show("Data Updated!");
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();

            borrow.BorrowID = int.Parse(textBorrowID.Text);


            connection.Delete(borrow);
            DisplayData();
            MessageBox.Show("Data Deleted!");
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void butGTM_Click(object sender, EventArgs e)
        {

            new MenuPageForm().Show();
            this.Hide();

        }

        private void dataGridViewBorrowing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBorrowID.Text = dataGridViewBorrowing.CurrentRow.Cells["BorrowID"].Value.ToString();
            textReaderID.Text = dataGridViewBorrowing.CurrentRow.Cells["ReaderID"].Value.ToString();
            textBorrowDate.Text = dataGridViewBorrowing.CurrentRow.Cells["BorrowDate"].Value.ToString();
            textReturnDate.Text = dataGridViewBorrowing.CurrentRow.Cells["ReturnDate"].Value.ToString();
            textBookID.Text = dataGridViewBorrowing.CurrentRow.Cells["BookID"].Value.ToString();
        }
    }
}
