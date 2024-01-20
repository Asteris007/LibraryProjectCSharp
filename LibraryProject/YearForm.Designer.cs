namespace LibraryProject
{
    partial class YearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewYear = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textYearID = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butGTM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1988, 165);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(894, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // dataGridViewYear
            // 
            this.dataGridViewYear.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridViewYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYear.Location = new System.Drawing.Point(5, 638);
            this.dataGridViewYear.Name = "dataGridViewYear";
            this.dataGridViewYear.RowHeadersWidth = 102;
            this.dataGridViewYear.RowTemplate.Height = 40;
            this.dataGridViewYear.Size = new System.Drawing.Size(1992, 341);
            this.dataGridViewYear.TabIndex = 24;
            this.dataGridViewYear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYear_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1994, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 60);
            this.label2.TabIndex = 41;
            this.label2.Text = "Year ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 60);
            this.label3.TabIndex = 42;
            this.label3.Text = "Year ";
            // 
            // textYearID
            // 
            this.textYearID.BackColor = System.Drawing.Color.Gold;
            this.textYearID.Location = new System.Drawing.Point(1067, 310);
            this.textYearID.Name = "textYearID";
            this.textYearID.Size = new System.Drawing.Size(589, 38);
            this.textYearID.TabIndex = 43;
            // 
            // textYear
            // 
            this.textYear.BackColor = System.Drawing.Color.Gold;
            this.textYear.Location = new System.Drawing.Point(1067, 409);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(589, 38);
            this.textYear.TabIndex = 44;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Gold;
            this.butSave.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(81, 502);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(233, 116);
            this.butSave.TabIndex = 52;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Gold;
            this.butShow.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.Location = new System.Drawing.Point(386, 497);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(243, 123);
            this.butShow.TabIndex = 53;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.Gold;
            this.butEdit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.Location = new System.Drawing.Point(719, 502);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(230, 125);
            this.butEdit.TabIndex = 54;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Gold;
            this.butDelete.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(1043, 502);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(242, 123);
            this.butDelete.TabIndex = 55;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Gold;
            this.butExit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1371, 502);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(251, 119);
            this.butExit.TabIndex = 56;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butGTM
            // 
            this.butGTM.BackColor = System.Drawing.Color.Gold;
            this.butGTM.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGTM.Location = new System.Drawing.Point(1705, 501);
            this.butGTM.Name = "butGTM";
            this.butGTM.Size = new System.Drawing.Size(243, 125);
            this.butGTM.TabIndex = 57;
            this.butGTM.Text = " Menu";
            this.butGTM.UseVisualStyleBackColor = false;
            this.butGTM.Click += new System.EventHandler(this.butGTM_Click);
            // 
            // YearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1996, 975);
            this.Controls.Add(this.butGTM);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textYearID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewYear);
            this.Controls.Add(this.panel1);
            this.Name = "YearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textYearID;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butGTM;
    }
}