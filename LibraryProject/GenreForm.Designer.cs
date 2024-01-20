namespace LibraryProject
{
    partial class GenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenreForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textGenreID = new System.Windows.Forms.TextBox();
            this.textGenreName = new System.Windows.Forms.TextBox();
            this.butGTM = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-588, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2200, 196);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1267, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre";
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Location = new System.Drawing.Point(-4, 720);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.RowHeadersWidth = 102;
            this.dataGridViewGenre.RowTemplate.Height = 40;
            this.dataGridViewGenre.Size = new System.Drawing.Size(1616, 478);
            this.dataGridViewGenre.TabIndex = 23;
            this.dataGridViewGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenre_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1616, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 60);
            this.label2.TabIndex = 40;
            this.label2.Text = "Genre ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 60);
            this.label3.TabIndex = 41;
            this.label3.Text = "Genre Name";
            // 
            // textGenreID
            // 
            this.textGenreID.BackColor = System.Drawing.Color.Gold;
            this.textGenreID.Location = new System.Drawing.Point(771, 277);
            this.textGenreID.Name = "textGenreID";
            this.textGenreID.Size = new System.Drawing.Size(589, 38);
            this.textGenreID.TabIndex = 42;
            // 
            // textGenreName
            // 
            this.textGenreName.BackColor = System.Drawing.Color.Gold;
            this.textGenreName.Location = new System.Drawing.Point(771, 394);
            this.textGenreName.Name = "textGenreName";
            this.textGenreName.Size = new System.Drawing.Size(589, 38);
            this.textGenreName.TabIndex = 43;
            // 
            // butGTM
            // 
            this.butGTM.BackColor = System.Drawing.Color.Gold;
            this.butGTM.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGTM.Location = new System.Drawing.Point(1348, 578);
            this.butGTM.Name = "butGTM";
            this.butGTM.Size = new System.Drawing.Size(223, 136);
            this.butGTM.TabIndex = 49;
            this.butGTM.Text = " Menu";
            this.butGTM.UseVisualStyleBackColor = false;
            this.butGTM.Click += new System.EventHandler(this.butGTM_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Gold;
            this.butExit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1087, 578);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(210, 136);
            this.butExit.TabIndex = 50;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Gold;
            this.butSave.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(23, 578);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(212, 136);
            this.butSave.TabIndex = 51;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Gold;
            this.butShow.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.Location = new System.Drawing.Point(279, 578);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(219, 136);
            this.butShow.TabIndex = 52;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.Gold;
            this.butEdit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.Location = new System.Drawing.Point(541, 578);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(221, 136);
            this.butEdit.TabIndex = 53;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Gold;
            this.butDelete.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(807, 578);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(232, 136);
            this.butDelete.TabIndex = 54;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1610, 1210);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butGTM);
            this.Controls.Add(this.textGenreName);
            this.Controls.Add(this.textGenreID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewGenre);
            this.Controls.Add(this.panel1);
            this.Name = "GenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGenreID;
        private System.Windows.Forms.TextBox textGenreName;
        private System.Windows.Forms.Button butGTM;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
    }
}