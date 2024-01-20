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
    public partial class GenreForm : Form
    {
        Connection connection = new Connection();
        private List<Genre> genreList = new List<Genre>();
        public GenreForm()
        {
            InitializeComponent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {

            Genre genre = new Genre();
            genre.GenreID = int.Parse(textGenreID.Text);
            genre.GenreName = textGenreID.Text;
            connection.Save(genre);
            displayData();
            MessageBox.Show("Data Saved");
        }

        private void displayData()
        {
            string query = "SELECT   Genre.GenreID, Genre.GenreName,Books.Title " +
                                    "FROM Books " +
                                    "INNER JOIN Genre ON Books.GenreID = Genre.GenreID ";
               
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewGenre.DataSource = ds.Tables[0];

                genreList = ds.Tables[0].AsEnumerable().Select(row => new Genre
                {
                    GenreID = row.Field<int>("GenreID"),
                    GenreName = row.Field<string>("GenreName"),
                    

                }).ToList();
            }
        }


        private void butShow_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {

            Genre genre = new Genre();
            genre.GenreID = int.Parse(textGenreID.Text);
            genre.GenreName = textGenreName.Text;
            connection.Update(genre);
            displayData();
            MessageBox.Show("Data Updated!");
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.GenreID = int.Parse(textGenreID.Text);
            genre.GenreName = textGenreName.Text;
            connection.Delete(genre);
            displayData();
            MessageBox.Show("Data Deleted!");
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butGTM_Click(object sender, EventArgs e)
        {
            new AdminMenuForm().Show();
            this.Hide();
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textGenreID.Text = dataGridViewGenre.CurrentRow.Cells["GenreID"].Value.ToString();
            textGenreName.Text = dataGridViewGenre.CurrentRow.Cells["GenreName"].Value.ToString();
        }
    }
}
