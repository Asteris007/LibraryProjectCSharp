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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.OleDb;

namespace LibraryProject
{
    public partial class BooksForm : Form
    {
        Connection connection = new Connection();
        private List<Books> booksList = new List<Books>();
        public BooksForm()
        {
            InitializeComponent();
        }




        private void displayData() { 
            string query = "SELECT Books.BookID, Books.Title, Books.AuthorID, Authors.AuthorName, " +
                   "Books.GenreID, Genre.GenreName, Books.YearID, Year.YearValue " +
                   "FROM Books " +
                   "INNER JOIN Authors ON Books.AuthorID = Authors.AuthorID " +
                   "INNER JOIN Genre ON Books.GenreID = Genre.GenreID " +
                   "INNER JOIN Year ON Books.YearID = Year.YearID";
        
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewBooks.DataSource = ds.Tables[0];

                booksList = ds.Tables[0].AsEnumerable().Select(row => new Books
                {
                    BookID = row.Field<int>("BookID"),
                    Title = row.Field<string>("Title"),
                    AuthorID = row.Field<int>("AuthorID"),
                  GenreID = row.Field<int>("GenreID"),
                  YearID = row.Field<int>("YearID"),
                   
                }).ToList();
            }
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.BookID = int.Parse(textBooks.Text);
            books.Title = textTitle.Text;
            books.AuthorID = int.Parse(textAuthor.Text);
            books.GenreID = int.Parse(texGenre.Text);
            books.YearID = int.Parse(textYear.Text);

            connection.Save(books);
            displayData();
            MessageBox.Show("Data Saved");
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            new MenuPageForm().Show();
            this.Hide();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.BookID = int.Parse(textBooks.Text);
            books.Title = textTitle.Text;
            books.AuthorID = int.Parse(textAuthor.Text);
            books.GenreID = int.Parse(texGenre.Text);
            books.YearID = int.Parse(textYear.Text);

            connection.Update(books);
            displayData();
            MessageBox.Show("Data Updated!");
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.BookID = int.Parse(textBooks.Text);
            books.Title = textTitle.Text;
            books.AuthorID = int.Parse(textAuthor.Text);
            books.GenreID = int.Parse(texGenre.Text);
            books.YearID = int.Parse(textYear.Text);

            connection.Delete(books);
            displayData();
            MessageBox.Show("Data Deleted!");
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBooks.Text = dataGridViewBooks.CurrentRow.Cells["BookID"].Value.ToString();
            textTitle.Text = dataGridViewBooks.CurrentRow.Cells["Title"].Value.ToString();
            textAuthor.Text = dataGridViewBooks.CurrentRow.Cells["AuthorID"].Value.ToString();
            texGenre.Text = dataGridViewBooks.CurrentRow.Cells["GenreID"].Value.ToString();
            textYear.Text = dataGridViewBooks.CurrentRow.Cells["YearID"].Value.ToString();
        }
    }
}
