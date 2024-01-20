namespace LibraryProject
{
    partial class MenuPageForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.readersButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.exitButton.Location = new System.Drawing.Point(1882, 848);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(363, 254);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.booksButton.Location = new System.Drawing.Point(72, 947);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(358, 249);
            this.booksButton.TabIndex = 3;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.borrowButton.Location = new System.Drawing.Point(72, 266);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(358, 249);
            this.borrowButton.TabIndex = 2;
            this.borrowButton.Text = "Borrowing";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // readersButton
            // 
            this.readersButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readersButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.readersButton.Location = new System.Drawing.Point(72, 595);
            this.readersButton.Name = "readersButton";
            this.readersButton.Size = new System.Drawing.Size(358, 256);
            this.readersButton.TabIndex = 1;
            this.readersButton.Text = "Readers";
            this.readersButton.UseVisualStyleBackColor = true;
            this.readersButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2359, 171);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(623, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(996, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Managment System";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Location = new System.Drawing.Point(1882, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 272);
            this.button2.TabIndex = 6;
            this.button2.Text = "Admin Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.dataBAse;
            this.pictureBox1.Location = new System.Drawing.Point(436, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 1132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2354, 1380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readersButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.panel2);
            this.Name = "MenuPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button readersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}