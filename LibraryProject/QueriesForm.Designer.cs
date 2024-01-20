namespace LibraryProject
{
    partial class QueriesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.butReadersByAge = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.queryAVLR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1870, 188);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(367, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1091, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "Queries and Diagrams";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.butReadersByAge);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.queryAVLR);
            this.panel2.Location = new System.Drawing.Point(48, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1781, 945);
            this.panel2.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gold;
            this.button8.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(159, 693);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(203, 184);
            this.button8.TabIndex = 60;
            this.button8.Text = "Menu";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gold;
            this.button7.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1389, 683);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 184);
            this.button7.TabIndex = 59;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // butReadersByAge
            // 
            this.butReadersByAge.BackColor = System.Drawing.Color.Goldenrod;
            this.butReadersByAge.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReadersByAge.ForeColor = System.Drawing.SystemColors.Control;
            this.butReadersByAge.Location = new System.Drawing.Point(1179, 50);
            this.butReadersByAge.Name = "butReadersByAge";
            this.butReadersByAge.Size = new System.Drawing.Size(531, 345);
            this.butReadersByAge.TabIndex = 58;
            this.butReadersByAge.Text = "Readers By Age Gender";
            this.butReadersByAge.UseVisualStyleBackColor = false;
            this.butReadersByAge.Click += new System.EventHandler(this.butReadersByAge_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Goldenrod;
            this.button5.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(610, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(521, 368);
            this.button5.TabIndex = 57;
            this.button5.Text = "Books By: Genre, Authors, Year";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // queryAVLR
            // 
            this.queryAVLR.BackColor = System.Drawing.Color.Goldenrod;
            this.queryAVLR.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryAVLR.ForeColor = System.Drawing.SystemColors.Control;
            this.queryAVLR.Location = new System.Drawing.Point(74, 54);
            this.queryAVLR.Name = "queryAVLR";
            this.queryAVLR.Size = new System.Drawing.Size(517, 341);
            this.queryAVLR.TabIndex = 53;
            this.queryAVLR.Text = "All Visitors Who are Late or not return";
            this.queryAVLR.UseVisualStyleBackColor = false;
            this.queryAVLR.Click += new System.EventHandler(this.queryAVLR_Click);
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1870, 1262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QueriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button butReadersByAge;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button queryAVLR;
    }
}