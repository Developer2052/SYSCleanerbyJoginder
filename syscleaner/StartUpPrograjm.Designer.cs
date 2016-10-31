namespace syscleaner
{
    partial class StartUpPrograjm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GridStartupProgram = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProcessBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerControl1 = new CustomControl.HeaderControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStartupProgram)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.headerControl1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 507);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 376);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GridStartupProgram);
            this.panel4.Location = new System.Drawing.Point(10, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 330);
            this.panel4.TabIndex = 1;
            // 
            // GridStartupProgram
            // 
            this.GridStartupProgram.AllowUserToAddRows = false;
            this.GridStartupProgram.AllowUserToDeleteRows = false;
            this.GridStartupProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStartupProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridStartupProgram.Location = new System.Drawing.Point(0, 0);
            this.GridStartupProgram.Name = "GridStartupProgram";
            this.GridStartupProgram.ReadOnly = true;
            this.GridStartupProgram.Size = new System.Drawing.Size(694, 330);
            this.GridStartupProgram.TabIndex = 2;
            this.GridStartupProgram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStartupProgram_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProcessBar);
            this.panel3.Location = new System.Drawing.Point(7, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 28);
            this.panel3.TabIndex = 0;
            // 
            // ProcessBar
            // 
            this.ProcessBar.Location = new System.Drawing.Point(3, 3);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Size = new System.Drawing.Size(694, 22);
            this.ProcessBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::syscleaner.Properties.Resources.FooterImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.White;
            this.headerControl1.Location = new System.Drawing.Point(-2, -1);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(720, 90);
            this.headerControl1.TabIndex = 0;
            // 
            // StartUpPrograjm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 507);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUpPrograjm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUpPrograjm";
            this.Load += new System.EventHandler(this.StartUpPrograjm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridStartupProgram)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomControl.HeaderControl headerControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar ProcessBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView GridStartupProgram;
    }
}