namespace LibraryProject
{
    partial class BooksForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.texGenre = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butGTMenu = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2415, 162);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1157, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.Library_Management;
            this.pictureBox1.Location = new System.Drawing.Point(328, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1643, 836);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBooks
            // 
            this.textBooks.BackColor = System.Drawing.Color.Goldenrod;
            this.textBooks.Location = new System.Drawing.Point(1196, 339);
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(499, 38);
            this.textBooks.TabIndex = 2;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(-1, 1006);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 102;
            this.dataGridViewBooks.RowTemplate.Height = 40;
            this.dataGridViewBooks.Size = new System.Drawing.Size(2415, 554);
            this.dataGridViewBooks.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "BookID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 61);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 61);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(806, 724);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 61);
            this.label5.TabIndex = 7;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(803, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 61);
            this.label6.TabIndex = 8;
            this.label6.Text = "Genre";
            // 
            // textYear
            // 
            this.textYear.BackColor = System.Drawing.Color.Goldenrod;
            this.textYear.Location = new System.Drawing.Point(1196, 732);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(499, 38);
            this.textYear.TabIndex = 9;
            // 
            // texGenre
            // 
            this.texGenre.BackColor = System.Drawing.Color.Goldenrod;
            this.texGenre.Location = new System.Drawing.Point(1196, 634);
            this.texGenre.Name = "texGenre";
            this.texGenre.Size = new System.Drawing.Size(499, 38);
            this.texGenre.TabIndex = 10;
            // 
            // textAuthor
            // 
            this.textAuthor.BackColor = System.Drawing.Color.Goldenrod;
            this.textAuthor.Location = new System.Drawing.Point(1196, 529);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(499, 38);
            this.textAuthor.TabIndex = 11;
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.textTitle.Location = new System.Drawing.Point(1196, 425);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(499, 38);
            this.textTitle.TabIndex = 12;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.butSave.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(328, 853);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(199, 151);
            this.butSave.TabIndex = 13;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butGTMenu
            // 
            this.butGTMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.butGTMenu.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGTMenu.Location = new System.Drawing.Point(1715, 853);
            this.butGTMenu.Name = "butGTMenu";
            this.butGTMenu.Size = new System.Drawing.Size(256, 147);
            this.butGTMenu.TabIndex = 14;
            this.butGTMenu.Text = "Menu";
            this.butGTMenu.UseVisualStyleBackColor = false;
            this.butGTMenu.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.butEdit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.Location = new System.Drawing.Point(840, 857);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(224, 147);
            this.butEdit.TabIndex = 15;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.MediumTurquoise;
            this.butShow.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.Location = new System.Drawing.Point(588, 857);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(199, 147);
            this.butShow.TabIndex = 16;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.butDelete.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(1126, 853);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(229, 147);
            this.butDelete.TabIndex = 17;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.butExit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1420, 853);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(226, 147);
            this.butExit.TabIndex = 18;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2413, 1572);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butGTMenu);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.texGenre);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2000, 1600);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox texGenre;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butGTMenu;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butExit;
    }
}