namespace LibraryProject
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBorrowing = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBorrowID = new System.Windows.Forms.TextBox();
            this.textBookID = new System.Windows.Forms.TextBox();
            this.textReaderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butGTM = new System.Windows.Forms.Button();
            this.textReturnDate = new System.Windows.Forms.TextBox();
            this.textBorrowDate = new System.Windows.Forms.TextBox();
            this.butShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2571, 192);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(957, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrowing";
            // 
            // dataGridViewBorrowing
            // 
            this.dataGridViewBorrowing.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridViewBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowing.Location = new System.Drawing.Point(-5, 900);
            this.dataGridViewBorrowing.Name = "dataGridViewBorrowing";
            this.dataGridViewBorrowing.RowHeadersWidth = 102;
            this.dataGridViewBorrowing.RowTemplate.Height = 40;
            this.dataGridViewBorrowing.Size = new System.Drawing.Size(2571, 400);
            this.dataGridViewBorrowing.TabIndex = 2;
            this.dataGridViewBorrowing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBorrowing_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1892, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBorrowID
            // 
            this.textBorrowID.BackColor = System.Drawing.SystemColors.Info;
            this.textBorrowID.Location = new System.Drawing.Point(754, 252);
            this.textBorrowID.Name = "textBorrowID";
            this.textBorrowID.Size = new System.Drawing.Size(568, 38);
            this.textBorrowID.TabIndex = 5;
            // 
            // textBookID
            // 
            this.textBookID.BackColor = System.Drawing.SystemColors.Info;
            this.textBookID.Location = new System.Drawing.Point(754, 587);
            this.textBookID.Name = "textBookID";
            this.textBookID.Size = new System.Drawing.Size(568, 38);
            this.textBookID.TabIndex = 6;
            // 
            // textReaderID
            // 
            this.textReaderID.BackColor = System.Drawing.SystemColors.Info;
            this.textReaderID.Location = new System.Drawing.Point(754, 343);
            this.textReaderID.Name = "textReaderID";
            this.textReaderID.Size = new System.Drawing.Size(568, 38);
            this.textReaderID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrow ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Borrow Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Aquamarine;
            this.label6.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "Visitor ID";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Pink;
            this.butSave.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(458, 750);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(243, 131);
            this.butSave.TabIndex = 12;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.Pink;
            this.butEdit.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.Location = new System.Drawing.Point(1020, 750);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(211, 131);
            this.butEdit.TabIndex = 14;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Pink;
            this.butDelete.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(1280, 750);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(241, 131);
            this.butDelete.TabIndex = 15;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Pink;
            this.butExit.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1574, 750);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(236, 131);
            this.butExit.TabIndex = 16;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butGTM
            // 
            this.butGTM.BackColor = System.Drawing.Color.Pink;
            this.butGTM.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGTM.Location = new System.Drawing.Point(1835, 750);
            this.butGTM.Name = "butGTM";
            this.butGTM.Size = new System.Drawing.Size(239, 131);
            this.butGTM.TabIndex = 17;
            this.butGTM.Text = "Menu";
            this.butGTM.UseVisualStyleBackColor = false;
            this.butGTM.Click += new System.EventHandler(this.butGTM_Click);
            // 
            // textReturnDate
            // 
            this.textReturnDate.BackColor = System.Drawing.SystemColors.Info;
            this.textReturnDate.Location = new System.Drawing.Point(754, 506);
            this.textReturnDate.Name = "textReturnDate";
            this.textReturnDate.Size = new System.Drawing.Size(568, 38);
            this.textReturnDate.TabIndex = 18;
            // 
            // textBorrowDate
            // 
            this.textBorrowDate.BackColor = System.Drawing.SystemColors.Info;
            this.textBorrowDate.Location = new System.Drawing.Point(754, 427);
            this.textBorrowDate.Name = "textBorrowDate";
            this.textBorrowDate.Size = new System.Drawing.Size(568, 38);
            this.textBorrowDate.TabIndex = 19;
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Pink;
            this.butShow.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.Location = new System.Drawing.Point(754, 750);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(218, 131);
            this.butShow.TabIndex = 13;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(2568, 1312);
            this.Controls.Add(this.textBorrowDate);
            this.Controls.Add(this.textReturnDate);
            this.Controls.Add(this.butGTM);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textReaderID);
            this.Controls.Add(this.textBookID);
            this.Controls.Add(this.textBorrowID);
            this.Controls.Add(this.dataGridViewBorrowing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(2600, 1400);
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBorrowing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBorrowID;
        private System.Windows.Forms.TextBox textBookID;
        private System.Windows.Forms.TextBox textReaderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butGTM;
        private System.Windows.Forms.TextBox textReturnDate;
        private System.Windows.Forms.TextBox textBorrowDate;
        private System.Windows.Forms.Button butShow;
    }
}