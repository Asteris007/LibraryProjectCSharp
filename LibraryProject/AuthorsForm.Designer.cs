namespace LibraryProject
{
    partial class AuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAuthorID = new System.Windows.Forms.TextBox();
            this.textAuthorName = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butGTM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-370, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2587, 173);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1285, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authors";
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(-4, 910);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersWidth = 102;
            this.dataGridViewAuthors.RowTemplate.Height = 40;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(2216, 389);
            this.dataGridViewAuthors.TabIndex = 22;
            this.dataGridViewAuthors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthors_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2221, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 60);
            this.label2.TabIndex = 39;
            this.label2.Text = "Author ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 60);
            this.label3.TabIndex = 40;
            this.label3.Text = "Author Name";
            // 
            // textAuthorID
            // 
            this.textAuthorID.BackColor = System.Drawing.Color.Gold;
            this.textAuthorID.Location = new System.Drawing.Point(786, 456);
            this.textAuthorID.Name = "textAuthorID";
            this.textAuthorID.Size = new System.Drawing.Size(589, 38);
            this.textAuthorID.TabIndex = 41;
            // 
            // textAuthorName
            // 
            this.textAuthorName.BackColor = System.Drawing.Color.Gold;
            this.textAuthorName.Location = new System.Drawing.Point(786, 586);
            this.textAuthorName.Name = "textAuthorName";
            this.textAuthorName.Size = new System.Drawing.Size(589, 38);
            this.textAuthorName.TabIndex = 42;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Gold;
            this.butSave.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(221, 765);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(272, 139);
            this.butSave.TabIndex = 43;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Gold;
            this.butShow.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.Location = new System.Drawing.Point(568, 765);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(281, 139);
            this.butShow.TabIndex = 44;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.Gold;
            this.butEdit.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.Location = new System.Drawing.Point(932, 765);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(270, 139);
            this.butEdit.TabIndex = 45;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Gold;
            this.butDelete.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(1278, 765);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(277, 139);
            this.butDelete.TabIndex = 46;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Gold;
            this.butExit.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1602, 765);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(243, 139);
            this.butExit.TabIndex = 47;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butGTM
            // 
            this.butGTM.BackColor = System.Drawing.Color.Gold;
            this.butGTM.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGTM.Location = new System.Drawing.Point(1906, 765);
            this.butGTM.Name = "butGTM";
            this.butGTM.Size = new System.Drawing.Size(246, 139);
            this.butGTM.TabIndex = 48;
            this.butGTM.Text = "Menu";
            this.butGTM.UseVisualStyleBackColor = false;
            this.butGTM.Click += new System.EventHandler(this.butGTM_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(2214, 1295);
            this.Controls.Add(this.butGTM);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.textAuthorName);
            this.Controls.Add(this.textAuthorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Controls.Add(this.panel1);
            this.Name = "AuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAuthorID;
        private System.Windows.Forms.TextBox textAuthorName;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butGTM;
    }
}