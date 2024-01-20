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
    public partial class AuthorsForm : Form
    {
        Connection connection = new Connection();
        private List<Authors> authorsList = new List<Authors>();
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Authors authors = new Authors();
            
            authors.AuthorID= int.Parse(textAuthorID.Text);
            authors.AuthorName= textAuthorName.Text;

            connection.Save(authors);
            displayData();
            MessageBox.Show("Data Saved");
        }

        private void displayData()
        {
            string query = "SELECT Authors.AuthorID, Authors.AuthorName, Books.Title, Genre.GenreName, Year.YearValue " +
                                    "FROM Books " +
                                    "INNER JOIN Authors ON Books.AuthorID = Authors.AuthorID " +
                                    "INNER JOIN Genre ON Books.GenreID = Genre.GenreID " +
                                    "INNER JOIN Year ON Books.YearID = Year.YearID";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewAuthors.DataSource = ds.Tables[0];

                authorsList = ds.Tables[0].AsEnumerable().Select(row => new Authors
                {
                    AuthorID = row.Field<int>("AuthorID"),
                    AuthorName = row.Field<string>("AuthorName") ?? string.Empty,



                }).ToList();
            }
        }

            private void butEdit_Click(object sender, EventArgs e)
        {
                Authors authors = new Authors();

                authors.AuthorID = int.Parse(textAuthorID.Text);
                authors.AuthorName = textAuthorName.Text;

                connection.Update(authors);
                displayData();
                MessageBox.Show("Data Updated!");
        }



        private void butDelete_Click(object sender, EventArgs e)
        {
            Authors authors = new Authors();

            authors.AuthorID = int.Parse(textAuthorID.Text);
            authors.AuthorName = textAuthorName.Text;

            connection.Delete(authors);
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

        private void dataGridViewAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                textAuthorID.Text = dataGridViewAuthors.CurrentRow.Cells["AuthorID"].Value.ToString();
                textAuthorName.Text = dataGridViewAuthors.CurrentRow.Cells["AuthorName"].Value.ToString();
            }

        private void butShow_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
        }
    
