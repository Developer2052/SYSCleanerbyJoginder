namespace syscleaner
{
    partial class AllCollectioin
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
            this.PicClosed = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblSoftwareVersion = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblSizeOfRam = new System.Windows.Forms.Label();
            this.lblWindowsVersion = new System.Windows.Forms.Label();
            this.LblNameofWindows = new System.Windows.Forms.Label();
            this.PicFooter = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFooter)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PicClosed);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 25);
            this.panel1.TabIndex = 1;
            // 
            // PicClosed
            // 
            this.PicClosed.Dock = System.Windows.Forms.DockStyle.Right;
            this.PicClosed.Image = global::syscleaner.Properties.Resources.ClosedButton1;
            this.PicClosed.Location = new System.Drawing.Point(905, 0);
            this.PicClosed.Name = "PicClosed";
            this.PicClosed.Size = new System.Drawing.Size(47, 25);
            this.PicClosed.TabIndex = 1;
            this.PicClosed.TabStop = false;
            this.PicClosed.Click += new System.EventHandler(this.PicClosed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::syscleaner.Properties.Resources.Logonew;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 53);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblSoftwareVersion);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(796, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 53);
            this.panel4.TabIndex = 4;
            // 
            // LblSoftwareVersion
            // 
            this.LblSoftwareVersion.AutoSize = true;
            this.LblSoftwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSoftwareVersion.ForeColor = System.Drawing.Color.White;
            this.LblSoftwareVersion.Location = new System.Drawing.Point(5, 36);
            this.LblSoftwareVersion.Name = "LblSoftwareVersion";
            this.LblSoftwareVersion.Size = new System.Drawing.Size(147, 20);
            this.LblSoftwareVersion.TabIndex = 6;
            this.LblSoftwareVersion.Text = "Software Version";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::syscleaner.Properties.Resources.Sys_Clear_With_White_Name1;
            this.pictureBox3.Location = new System.Drawing.Point(9, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 37);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblSizeOfRam);
            this.panel3.Controls.Add(this.lblWindowsVersion);
            this.panel3.Controls.Add(this.LblNameofWindows);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 53);
            this.panel3.TabIndex = 3;
            // 
            // LblSizeOfRam
            // 
            this.LblSizeOfRam.AutoSize = true;
            this.LblSizeOfRam.ForeColor = System.Drawing.Color.White;
            this.LblSizeOfRam.Location = new System.Drawing.Point(34, 20);
            this.LblSizeOfRam.Name = "LblSizeOfRam";
            this.LblSizeOfRam.Size = new System.Drawing.Size(82, 13);
            this.LblSizeOfRam.TabIndex = 8;
            this.LblSizeOfRam.Text = "ProcessorName";
            // 
            // lblWindowsVersion
            // 
            this.lblWindowsVersion.AutoSize = true;
            this.lblWindowsVersion.ForeColor = System.Drawing.Color.White;
            this.lblWindowsVersion.Location = new System.Drawing.Point(34, 1);
            this.lblWindowsVersion.Name = "lblWindowsVersion";
            this.lblWindowsVersion.Size = new System.Drawing.Size(89, 13);
            this.lblWindowsVersion.TabIndex = 7;
            this.lblWindowsVersion.Text = "Windows Version";
            // 
            // LblNameofWindows
            // 
            this.LblNameofWindows.AutoSize = true;
            this.LblNameofWindows.ForeColor = System.Drawing.Color.White;
            this.LblNameofWindows.Location = new System.Drawing.Point(34, 38);
            this.LblNameofWindows.Name = "LblNameofWindows";
            this.LblNameofWindows.Size = new System.Drawing.Size(82, 13);
            this.LblNameofWindows.TabIndex = 6;
            this.LblNameofWindows.Text = "Name of system";
            // 
            // PicFooter
            // 
            this.PicFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PicFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PicFooter.Image = global::syscleaner.Properties.Resources.FooterImage;
            this.PicFooter.Location = new System.Drawing.Point(0, 469);
            this.PicFooter.Name = "PicFooter";
            this.PicFooter.Size = new System.Drawing.Size(952, 50);
            this.PicFooter.TabIndex = 3;
            this.PicFooter.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(952, 5);
            this.progressBar1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.progressBar1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(952, 391);
            this.panel5.TabIndex = 4;
            // 
            // AllCollectioin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 519);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PicFooter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllCollectioin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllCollectioin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFooter)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicClosed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblSizeOfRam;
        private System.Windows.Forms.Label lblWindowsVersion;
        private System.Windows.Forms.Label LblNameofWindows;
        private System.Windows.Forms.Label LblSoftwareVersion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PicFooter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel5;
    }
}