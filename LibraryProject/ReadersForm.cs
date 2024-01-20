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

namespace LibraryProject
{
    public partial class ReadersForm : Form
    {

        Connection connection = new Connection();
        private List<Readers> readerList = new List<Readers>();
        public ReadersForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            Readers readers = new Readers  
            {
                ReaderID = int.Parse(textVisitorID.Text),
                FirstName = textFirstName.Text,
                SecondName = textSecondName.Text,
                LastName = textLastNAme.Text,
                EGN = textEGN.Text
            };

            connection.Save(readers);
            DisplayData();
            MessageBox.Show("Data Saved");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new MenuPageForm().Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

            private void DisplayData()
            {
                string query = "SELECT * FROM Readers";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridViewReaders.DataSource = ds.Tables[0];

                readerList = ds.Tables[0].AsEnumerable().Select(row => new Readers
                {
                    ReaderID = row.Field<int>("ReaderID"),
                    FirstName = row.Field<string>("FirstName"),
                    SecondName = row.Field<string>("SecondName"),
                    LastName = row.Field<string>("LastName"),
                    EGN = row.Field<string>("EGN"),
                }).ToList();
            }
            }
        

        private void editButton_Click(object sender, EventArgs e)
        {
            Readers readers = new Readers
            {
                ReaderID = int.Parse(textVisitorID.Text),
                FirstName = textFirstName.Text,
                SecondName = textSecondName.Text,
                LastName = textLastNAme.Text,
                EGN = textEGN.Text
            };

            connection.Update(readers);
            DisplayData();
            MessageBox.Show("Data Updated!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Readers readers = new Readers
            {
                ReaderID = int.Parse(textVisitorID.Text),
                FirstName = textFirstName.Text,
                SecondName = textSecondName.Text,
                LastName = textLastNAme.Text,
                EGN = textEGN.Text
            };

            connection.Delete(readers);
            DisplayData();

            MessageBox.Show("Data Deleted!");
        }

        private void dataGridViewReaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textVisitorID.Text = dataGridViewReaders.CurrentRow.Cells["ReaderID"].Value.ToString();
            textFirstName.Text = dataGridViewReaders.CurrentRow.Cells["FirstName"].Value.ToString();
            textSecondName.Text = dataGridViewReaders.CurrentRow.Cells["SecondName"].Value.ToString();
            textLastNAme.Text = dataGridViewReaders.CurrentRow.Cells["LastName"].Value.ToString();
            textEGN.Text = dataGridViewReaders.CurrentRow.Cells["EGN"].Value.ToString();

        }
    }
}
