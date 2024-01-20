namespace LibraryProject
{
    partial class ReadersByAgeAndGender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.butReturn = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).BeginInit();
            this.SuspendLayout();
            // 
            // butReturn
            // 
            this.butReturn.BackColor = System.Drawing.Color.Gray;
            this.butReturn.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butReturn.Location = new System.Drawing.Point(668, 1053);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(414, 234);
            this.butReturn.TabIndex = 58;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = false;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Gray;
            this.butShow.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butShow.Location = new System.Drawing.Point(86, 1053);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(414, 234);
            this.butShow.TabIndex = 59;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butMenu
            // 
            this.butMenu.BackColor = System.Drawing.Color.Gray;
            this.butMenu.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butMenu.Location = new System.Drawing.Point(1289, 1053);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(414, 234);
            this.butMenu.TabIndex = 60;
            this.butMenu.Text = "Menu";
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Gray;
            this.butExit.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butExit.Location = new System.Drawing.Point(1888, 1053);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(414, 234);
            this.butExit.TabIndex = 61;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // chartGender
            // 
            this.chartGender.BackColor = System.Drawing.Color.Black;
            this.chartGender.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGender.Legends.Add(legend1);
            this.chartGender.Location = new System.Drawing.Point(12, 12);
            this.chartGender.Name = "chartGender";
            this.chartGender.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.chartGender.Series.Add(series1);
            this.chartGender.Size = new System.Drawing.Size(1135, 940);
            this.chartGender.TabIndex = 62;
            this.chartGender.Text = "Gender";
            title1.Name = "Gender";
            this.chartGender.Titles.Add(title1);
            // 
            // chartAge
            // 
            this.chartAge.BackColor = System.Drawing.Color.Black;
            this.chartAge.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chartAge.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAge.Legends.Add(legend2);
            this.chartAge.Location = new System.Drawing.Point(1161, 12);
            this.chartAge.Name = "chartAge";
            this.chartAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Age";
            this.chartAge.Series.Add(series2);
            this.chartAge.Size = new System.Drawing.Size(1275, 940);
            this.chartAge.TabIndex = 63;
            this.chartAge.Text = "Age";
            title2.Name = "Age";
            this.chartAge.Titles.Add(title2);
            // 
            // ReadersByAgeAndGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(2448, 1375);
            this.Controls.Add(this.chartAge);
            this.Controls.Add(this.chartGender);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butReturn);
            this.Name = "ReadersByAgeAndGender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadersByAgeAndGender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Button butExit;
       
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
    }
}