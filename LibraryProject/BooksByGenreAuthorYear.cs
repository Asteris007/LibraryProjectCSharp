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

namespace LibraryProject
{
    public partial class BooksByGenreAuthorYear : Form
    {
        Connection connection = new Connection();
        public BooksByGenreAuthorYear()
        {
            InitializeComponent();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textByGenre.Text, out int selectedGenreID))
            {
                MessageBox.Show("Please enter a valid integer for Genre ID.");
                return;
            }

            string query = $@"SELECT
                                    G.GenreID,
                                    G.GenreName,
                                    B.BookID,
                                    B.Title,
                                    A.AuthorName,
                                    Y.YearValue
                                FROM
                                    dbo.Books AS B
                                JOIN
                                    dbo.Genre AS G ON B.GenreID = G.GenreID
                                JOIN
                                    dbo.Authors AS A ON B.AuthorID = A.AuthorID
                                JOIN
                                    dbo.Year AS Y ON B.YearID = Y.YearID
                                WHERE
                                    G.GenreID = @GenreID";
            using (SqlCommand cmd = new SqlCommand(query, connection.connect))
            {
                // Add the GenreID parameter to the SqlCommand.
                cmd.Parameters.AddWithValue("@GenreID", selectedGenreID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridViewGenre.DataSource = ds.Tables[0];
                }
            }
        }

        private void butReturn_Click(object sender, EventArgs e)
        {
            new QueriesForm().Show();
            this.Hide();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            new MenuPageForm().Show();
            this.Hide();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewGenre.DataSource)?.Clear();
        }

        private void butCA_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewGenre.DataSource)?.Clear();
        }

        private void butCY_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewGenre.DataSource)?.Clear();
        }

        private void butSA_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textByAuthor.Text, out int selectedAuthorID))
            {
                MessageBox.Show("Please enter a valid integer for Author ID.");
                return;
            }

            string query = $@"SELECT
                                    A.AuthorID,
                                    A.AuthorName,
                                     B.BookID,
                                    B.Title,
                                    G.GenreName,
                                    Y.YearValue
                                FROM
                                    dbo.Books AS B
                                JOIN
                                    dbo.Genre AS G ON B.GenreID = G.GenreID
                                JOIN
                                    dbo.Authors AS A ON B.AuthorID = A.AuthorID
                                JOIN
                                    dbo.Year AS Y ON B.YearID = Y.YearID
                                WHERE
                                    A.AuthorID = @AuthorID";
            using (SqlCommand cmd = new SqlCommand(query, connection.connect))
            {
                // Add the GenreID parameter to the SqlCommand.
                cmd.Parameters.AddWithValue("@AuthorID", selectedAuthorID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridViewAuthor.DataSource = ds.Tables[0];
                }
            }
        }

        private void butSY_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textByYear.Text, out int selectedYearID))
            {
                MessageBox.Show("Please enter a valid integer for Year ID.");
                return;
            }

            string query = $@"SELECT
                                    Y.YearID,
                                    Y.YearValue,
                                    B.BookID,
                                    B.Title,
                                    A.AuthorID,
                                    A.AuthorName,
                                    G.GenreName
                                   
                                FROM
                                    dbo.Books AS B
                                JOIN
                                    dbo.Genre AS G ON B.GenreID = G.GenreID
                                JOIN
                                    dbo.Authors AS A ON B.AuthorID = A.AuthorID
                                JOIN
                                    dbo.Year AS Y ON B.YearID = Y.YearID
                                WHERE
                                    Y.YearID = @YearID";
            using (SqlCommand cmd = new SqlCommand(query, connection.connect))
            {
                
                cmd.Parameters.AddWithValue("@YearID", selectedYearID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridViewYear.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
