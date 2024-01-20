using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class ReadersByAgeAndGender : Form
    {
        Connection connection = new Connection();
        private List<Readers> readersList = new List<Readers>();
        ReadersProcessor rd;

        public ReadersByAgeAndGender()
        {
            InitializeComponent();
            InitializeChartSeries();
            rd = new ReadersProcessor(readersList);
        }

        private void InitializeChartSeries()
        {
           chartGender.Series.Add("Male");
            chartGender.Series.Add("Female");
            chartAge.Series.Add("< 10 years old");
            chartAge.Series.Add("< 18 years old");
            chartAge.Series.Add("< 30 years old");
            chartAge.Series.Add("< 65 years old");
            chartAge.Series.Add("> 65 years old");

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

        private void butReturn_Click(object sender, EventArgs e)
        {
            new AdminMenuForm().Show();
            this.Hide();
        }

        private void DisplayStatistics(List<ReaderStatistics> statistics)
        {


            chartGender.Series["Male"].Points.AddXY("Male", rd.countMale);
            chartGender.Series["Female"].Points.AddXY("Female", rd.countFemale);
            chartAge.Series["< 10 years old"].Points.AddXY("To 10 years", rd.to10);
            chartAge.Series["< 18 years old"].Points.AddXY("To 18 years", rd.to18);
            chartAge.Series["< 30 years old"].Points.AddXY("To 30 years", rd.to30);
            chartAge.Series["< 65 years old"].Points.AddXY("To 65 years", rd.to65);
            chartAge.Series["> 65 years old"].Points.AddXY("Up to 65 years", rd.up65);

            foreach (var stat in statistics)
            {
                chartGender.Series[stat.Gender].Points.AddXY(stat.Gender, stat.VisitorCount);
                chartAge.Series[stat.AgeRange].Points.AddXY(stat.AgeRange, stat.VisitorCount);
            }
        }



        private void butShow_Click(object sender, EventArgs e)
        {
          
            List<ReaderStatistics> statistics = rd.GetStatistics();
            DisplayStatistics(statistics);
        }

       
    }
}
