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
    public partial class YearForm : Form
    {
        Connection connection = new Connection();
        private List<Year> yearList = new List<Year>();
        public YearForm()
        {
            InitializeComponent();
        }

        private void displayData()
        {
            string query = "SELECT  Books.Title, Genre.GenreName, Year.YearID, Year.YearValue " +
                                    "FROM Books " +
                                    "INNER JOIN Genre ON Books.GenreID = Genre.GenreID " +
                                    "INNER JOIN Year ON Books.YearID = Year.YearID";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.connect))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewYear.DataSource = ds.Tables[0];

                yearList = ds.Tables[0].AsEnumerable().Select(row => new Year
                {     
                YearID = row.Field<int>("YearID"),
                    YearValue = row.Field<int>("YearValue"),


                }).ToList();
            }
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            Year year = new Year();

            year.YearID = int.Parse(textYearID.Text);
           year.YearValue = int.Parse(textYear.Text);

            connection.Save(year);
            displayData();
            MessageBox.Show("Data Saved");
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Year year = new Year();

            year.YearID = int.Parse(textYearID.Text);
            year.YearValue = int.Parse(textYear.Text);

            connection.Update(year);
            displayData();
           
            MessageBox.Show("Data Updated!");
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Year year = new Year();

            year.YearID = int.Parse(textYearID.Text);
            year.YearValue = int.Parse(textYear.Text);

            connection.Delete(year);
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

        private void dataGridViewYear_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textYearID.Text = dataGridViewYear.CurrentRow.Cells["YearID"].Value.ToString();
            textYear.Text = dataGridViewYear.CurrentRow.Cells["YearValue"].Value.ToString();
        }
    }
}
