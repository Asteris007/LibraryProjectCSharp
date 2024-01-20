namespace LibraryProject
{
    partial class BooksByGenreAuthorYear
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
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.dataGridViewYear = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butSB = new System.Windows.Forms.Button();
            this.butReturn = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.textByGenre = new System.Windows.Forms.TextBox();
            this.textByAuthor = new System.Windows.Forms.TextBox();
            this.textByYear = new System.Windows.Forms.TextBox();
            this.butSA = new System.Windows.Forms.Button();
            this.butSY = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butCA = new System.Windows.Forms.Button();
            this.butCY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Location = new System.Drawing.Point(553, 124);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.RowHeadersWidth = 102;
            this.dataGridViewGenre.RowTemplate.Height = 40;
            this.dataGridViewGenre.Size = new System.Drawing.Size(1407, 325);
            this.dataGridViewGenre.TabIndex = 0;
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(553, 488);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowHeadersWidth = 102;
            this.dataGridViewAuthor.RowTemplate.Height = 40;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1407, 332);
            this.dataGridViewAuthor.TabIndex = 1;
            // 
            // dataGridViewYear
            // 
            this.dataGridViewYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYear.Location = new System.Drawing.Point(553, 868);
            this.dataGridViewYear.Name = "dataGridViewYear";
            this.dataGridViewYear.RowHeadersWidth = 102;
            this.dataGridViewYear.RowTemplate.Height = 40;
            this.dataGridViewYear.Size = new System.Drawing.Size(1407, 320);
            this.dataGridViewYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(631, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books Queries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 53);
            this.label2.TabIndex = 42;
            this.label2.Text = "By Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 53);
            this.label3.TabIndex = 43;
            this.label3.Text = "By Authors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Broadway", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 868);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 53);
            this.label4.TabIndex = 44;
            this.label4.Text = "By Year";
            // 
            // butSB
            // 
            this.butSB.BackColor = System.Drawing.Color.Gold;
            this.butSB.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSB.Location = new System.Drawing.Point(338, 244);
            this.butSB.Name = "butSB";
            this.butSB.Size = new System.Drawing.Size(188, 65);
            this.butSB.TabIndex = 54;
            this.butSB.Text = "Show";
            this.butSB.UseVisualStyleBackColor = false;
            this.butSB.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butReturn
            // 
            this.butReturn.BackColor = System.Drawing.Color.Gold;
            this.butReturn.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReturn.Location = new System.Drawing.Point(553, 1237);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(279, 180);
            this.butReturn.TabIndex = 55;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = false;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // butMenu
            // 
            this.butMenu.BackColor = System.Drawing.Color.Gold;
            this.butMenu.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.Location = new System.Drawing.Point(999, 1237);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(279, 180);
            this.butMenu.TabIndex = 56;
            this.butMenu.Text = "Menu";
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Gold;
            this.butExit.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1436, 1237);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(279, 180);
            this.butExit.TabIndex = 57;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // textByGenre
            // 
            this.textByGenre.BackColor = System.Drawing.Color.Gold;
            this.textByGenre.Location = new System.Drawing.Point(338, 138);
            this.textByGenre.Name = "textByGenre";
            this.textByGenre.Size = new System.Drawing.Size(188, 38);
            this.textByGenre.TabIndex = 58;
            // 
            // textByAuthor
            // 
            this.textByAuthor.BackColor = System.Drawing.Color.Gold;
            this.textByAuthor.Location = new System.Drawing.Point(338, 513);
            this.textByAuthor.Name = "textByAuthor";
            this.textByAuthor.Size = new System.Drawing.Size(177, 38);
            this.textByAuthor.TabIndex = 59;
            // 
            // textByYear
            // 
            this.textByYear.BackColor = System.Drawing.Color.Gold;
            this.textByYear.Location = new System.Drawing.Point(338, 883);
            this.textByYear.Name = "textByYear";
            this.textByYear.Size = new System.Drawing.Size(177, 38);
            this.textByYear.TabIndex = 60;
            // 
            // butSA
            // 
            this.butSA.BackColor = System.Drawing.Color.Gold;
            this.butSA.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSA.Location = new System.Drawing.Point(338, 607);
            this.butSA.Name = "butSA";
            this.butSA.Size = new System.Drawing.Size(188, 65);
            this.butSA.TabIndex = 61;
            this.butSA.Text = "Show";
            this.butSA.UseVisualStyleBackColor = false;
            this.butSA.Click += new System.EventHandler(this.butSA_Click);
            // 
            // butSY
            // 
            this.butSY.BackColor = System.Drawing.Color.Gold;
            this.butSY.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSY.Location = new System.Drawing.Point(338, 1001);
            this.butSY.Name = "butSY";
            this.butSY.Size = new System.Drawing.Size(188, 65);
            this.butSY.TabIndex = 62;
            this.butSY.Text = "Show";
            this.butSY.UseVisualStyleBackColor = false;
            this.butSY.Click += new System.EventHandler(this.butSY_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.Gold;
            this.butClear.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(338, 360);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(188, 65);
            this.butClear.TabIndex = 63;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butCA
            // 
            this.butCA.BackColor = System.Drawing.Color.Gold;
            this.butCA.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCA.Location = new System.Drawing.Point(338, 717);
            this.butCA.Name = "butCA";
            this.butCA.Size = new System.Drawing.Size(188, 65);
            this.butCA.TabIndex = 64;
            this.butCA.Text = "Clear";
            this.butCA.UseVisualStyleBackColor = false;
            this.butCA.Click += new System.EventHandler(this.butCA_Click);
            // 
            // butCY
            // 
            this.butCY.BackColor = System.Drawing.Color.Gold;
            this.butCY.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCY.Location = new System.Drawing.Point(338, 1123);
            this.butCY.Name = "butCY";
            this.butCY.Size = new System.Drawing.Size(188, 65);
            this.butCY.TabIndex = 65;
            this.butCY.Text = "Clear";
            this.butCY.UseVisualStyleBackColor = false;
            this.butCY.Click += new System.EventHandler(this.butCY_Click);
            // 
            // BooksByGenreAuthorYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1972, 1471);
            this.Controls.Add(this.butCY);
            this.Controls.Add(this.butCA);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butSY);
            this.Controls.Add(this.butSA);
            this.Controls.Add(this.textByYear);
            this.Controls.Add(this.textByAuthor);
            this.Controls.Add(this.textByGenre);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.butSB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewYear);
            this.Controls.Add(this.dataGridViewAuthor);
            this.Controls.Add(this.dataGridViewGenre);
            this.Name = "BooksByGenreAuthorYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksByGenreAuthorYear";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private System.Windows.Forms.DataGridView dataGridViewYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butSB;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.TextBox textByGenre;
        private System.Windows.Forms.TextBox textByAuthor;
        private System.Windows.Forms.TextBox textByYear;
        private System.Windows.Forms.Button butSA;
        private System.Windows.Forms.Button butSY;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butCA;
        private System.Windows.Forms.Button butCY;
    }
}