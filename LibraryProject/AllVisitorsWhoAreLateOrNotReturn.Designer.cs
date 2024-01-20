namespace LibraryProject
{
    partial class AllVisitorsWhoAreLateOrNotReturn
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
            this.dataGridViewAVLR = new System.Windows.Forms.DataGridView();
            this.butExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butQue = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAVLR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAVLR
            // 
            this.dataGridViewAVLR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAVLR.Location = new System.Drawing.Point(2, 204);
            this.dataGridViewAVLR.Name = "dataGridViewAVLR";
            this.dataGridViewAVLR.RowHeadersWidth = 102;
            this.dataGridViewAVLR.RowTemplate.Height = 40;
            this.dataGridViewAVLR.Size = new System.Drawing.Size(1624, 593);
            this.dataGridViewAVLR.TabIndex = 0;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Gold;
            this.butExit.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1086, 826);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(273, 165);
            this.butExit.TabIndex = 60;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(99, 826);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 165);
            this.button1.TabIndex = 61;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Broadway", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(107, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1339, 76);
            this.label1.TabIndex = 62;
            this.label1.Text = "Query for Late or Not Return Visitors";
            // 
            // butQue
            // 
            this.butQue.BackColor = System.Drawing.Color.Gold;
            this.butQue.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQue.Location = new System.Drawing.Point(435, 826);
            this.butQue.Name = "butQue";
            this.butQue.Size = new System.Drawing.Size(273, 165);
            this.butQue.TabIndex = 63;
            this.butQue.Text = "Return";
            this.butQue.UseVisualStyleBackColor = false;
            this.butQue.Click += new System.EventHandler(this.butQue_Click);
            // 
            // butMenu
            // 
            this.butMenu.BackColor = System.Drawing.Color.Gold;
            this.butMenu.Font = new System.Drawing.Font("Broadway", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.Location = new System.Drawing.Point(760, 826);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(273, 165);
            this.butMenu.TabIndex = 64;
            this.butMenu.Text = "Menu";
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // AllVisitorsWhoAreLateOrNotReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1630, 1020);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.butQue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.dataGridViewAVLR);
            this.Name = "AllVisitorsWhoAreLateOrNotReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllVisitorsWhoAreLateOrNotReturn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAVLR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAVLR;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butQue;
        private System.Windows.Forms.Button butMenu;
    }
}