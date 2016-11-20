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
            this._PnlTaskBar = new System.Windows.Forms.Panel();
            this._PicWindowsClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._TopPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblSoftwareVersion = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblSizeOfRam = new System.Windows.Forms.Label();
            this.lblWindowsVersion = new System.Windows.Forms.Label();
            this.LblNameofWindows = new System.Windows.Forms.Label();
            this._AllCollectionProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TabWindowsAndApplication = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChkWindowsList = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChkApplicationlist = new System.Windows.Forms.CheckedListBox();
            this._pnlHome = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PicFooter = new System.Windows.Forms.PictureBox();
            this._pnlIconContainer = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this._PictureBoxStartup = new System.Windows.Forms.PictureBox();
            this._PictureCleaner = new System.Windows.Forms.PictureBox();
            this._PnlTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PicWindowsClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._TopPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.TabWindowsAndApplication.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this._pnlHome.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFooter)).BeginInit();
            this._pnlIconContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBoxStartup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureCleaner)).BeginInit();
            this.SuspendLayout();
            // 
            // _PnlTaskBar
            // 
            this._PnlTaskBar.BackColor = System.Drawing.Color.White;
            this._PnlTaskBar.Controls.Add(this._PicWindowsClose);
            this._PnlTaskBar.Controls.Add(this.pictureBox1);
            this._PnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._PnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this._PnlTaskBar.Name = "_PnlTaskBar";
            this._PnlTaskBar.Size = new System.Drawing.Size(952, 25);
            this._PnlTaskBar.TabIndex = 1;
            // 
            // _PicWindowsClose
            // 
            this._PicWindowsClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._PicWindowsClose.Image = global::syscleaner.Properties.Resources.ClosedButton1;
            this._PicWindowsClose.Location = new System.Drawing.Point(905, 0);
            this._PicWindowsClose.Name = "_PicWindowsClose";
            this._PicWindowsClose.Size = new System.Drawing.Size(47, 25);
            this._PicWindowsClose.TabIndex = 1;
            this._PicWindowsClose.TabStop = false;
            this._PicWindowsClose.Click += new System.EventHandler(this.PicClosed_Click);
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
            // _TopPanel
            // 
            this._TopPanel.BackColor = System.Drawing.Color.Gray;
            this._TopPanel.Controls.Add(this.panel4);
            this._TopPanel.Controls.Add(this.panel3);
            this._TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._TopPanel.Location = new System.Drawing.Point(0, 25);
            this._TopPanel.Name = "_TopPanel";
            this._TopPanel.Size = new System.Drawing.Size(952, 53);
            this._TopPanel.TabIndex = 2;
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
            // _AllCollectionProgressBar
            // 
            this._AllCollectionProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._AllCollectionProgressBar.Location = new System.Drawing.Point(0, 78);
            this._AllCollectionProgressBar.Name = "_AllCollectionProgressBar";
            this._AllCollectionProgressBar.Size = new System.Drawing.Size(952, 10);
            this._AllCollectionProgressBar.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 381);
            this.panel5.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TabWindowsAndApplication);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(156, 381);
            this.panel9.TabIndex = 1;
            // 
            // TabWindowsAndApplication
            // 
            this.TabWindowsAndApplication.Controls.Add(this.tabPage1);
            this.TabWindowsAndApplication.Controls.Add(this.tabPage2);
            this.TabWindowsAndApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabWindowsAndApplication.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.TabWindowsAndApplication.Location = new System.Drawing.Point(0, 0);
            this.TabWindowsAndApplication.Name = "TabWindowsAndApplication";
            this.TabWindowsAndApplication.SelectedIndex = 0;
            this.TabWindowsAndApplication.Size = new System.Drawing.Size(156, 381);
            this.TabWindowsAndApplication.TabIndex = 0;
            this.TabWindowsAndApplication.SelectedIndexChanged += new System.EventHandler(this.TabWindowsAndApplication_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChkWindowsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(148, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Windows";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChkWindowsList
            // 
            this.ChkWindowsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.ChkWindowsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkWindowsList.CheckOnClick = true;
            this.ChkWindowsList.ForeColor = System.Drawing.Color.White;
            this.ChkWindowsList.FormattingEnabled = true;
            this.ChkWindowsList.Location = new System.Drawing.Point(3, 3);
            this.ChkWindowsList.Name = "ChkWindowsList";
            this.ChkWindowsList.Size = new System.Drawing.Size(142, 255);
            this.ChkWindowsList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChkApplicationlist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(148, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChkApplicationlist
            // 
            this.ChkApplicationlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(129)))), ((int)(((byte)(187)))));
            this.ChkApplicationlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkApplicationlist.CheckOnClick = true;
            this.ChkApplicationlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkApplicationlist.ForeColor = System.Drawing.Color.White;
            this.ChkApplicationlist.FormattingEnabled = true;
            this.ChkApplicationlist.Location = new System.Drawing.Point(3, 3);
            this.ChkApplicationlist.Name = "ChkApplicationlist";
            this.ChkApplicationlist.Size = new System.Drawing.Size(142, 349);
            this.ChkApplicationlist.TabIndex = 0;
            // 
            // _pnlHome
            // 
            this._pnlHome.BackColor = System.Drawing.Color.White;
            this._pnlHome.Controls.Add(this.panel2);
            this._pnlHome.Controls.Add(this.dataGridView1);
            this._pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlHome.Location = new System.Drawing.Point(156, 153);
            this._pnlHome.Name = "_pnlHome";
            this._pnlHome.Size = new System.Drawing.Size(796, 316);
            this._pnlHome.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnScan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 39);
            this.panel2.TabIndex = 1;
            // 
            // btnClean
            // 
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Image = global::syscleaner.Properties.Resources.buttonclean;
            this.btnClean.Location = new System.Drawing.Point(682, 0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(114, 39);
            this.btnClean.TabIndex = 4;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnScan
            // 
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Image = global::syscleaner.Properties.Resources.buttonscan;
            this.btnScan.Location = new System.Drawing.Point(0, 0);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(114, 39);
            this.btnScan.TabIndex = 3;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 316);
            this.dataGridView1.TabIndex = 0;
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
            // _pnlIconContainer
            // 
            this._pnlIconContainer.BackColor = System.Drawing.Color.White;
            this._pnlIconContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlIconContainer.Controls.Add(this.pictureBox7);
            this._pnlIconContainer.Controls.Add(this.pictureBox6);
            this._pnlIconContainer.Controls.Add(this.pictureBox5);
            this._pnlIconContainer.Controls.Add(this._PictureBoxStartup);
            this._pnlIconContainer.Controls.Add(this._PictureCleaner);
            this._pnlIconContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlIconContainer.Location = new System.Drawing.Point(156, 88);
            this._pnlIconContainer.Name = "_pnlIconContainer";
            this._pnlIconContainer.Size = new System.Drawing.Size(796, 65);
            this._pnlIconContainer.TabIndex = 6;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox7.Image = global::syscleaner.Properties.Resources.quicker;
            this.pictureBox7.Location = new System.Drawing.Point(636, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(159, 63);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox6.Image = global::syscleaner.Properties.Resources.quicker;
            this.pictureBox6.Location = new System.Drawing.Point(477, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(159, 63);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = global::syscleaner.Properties.Resources.quicker;
            this.pictureBox5.Location = new System.Drawing.Point(318, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(159, 63);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // _PictureBoxStartup
            // 
            this._PictureBoxStartup.Dock = System.Windows.Forms.DockStyle.Left;
            this._PictureBoxStartup.Image = global::syscleaner.Properties.Resources.quicker;
            this._PictureBoxStartup.Location = new System.Drawing.Point(159, 0);
            this._PictureBoxStartup.Name = "_PictureBoxStartup";
            this._PictureBoxStartup.Size = new System.Drawing.Size(159, 63);
            this._PictureBoxStartup.TabIndex = 1;
            this._PictureBoxStartup.TabStop = false;
            this._PictureBoxStartup.Click += new System.EventHandler(this._PictureBoxStartup_Click);
            // 
            // _PictureCleaner
            // 
            this._PictureCleaner.Dock = System.Windows.Forms.DockStyle.Left;
            this._PictureCleaner.Image = global::syscleaner.Properties.Resources.quicker;
            this._PictureCleaner.Location = new System.Drawing.Point(0, 0);
            this._PictureCleaner.Name = "_PictureCleaner";
            this._PictureCleaner.Size = new System.Drawing.Size(159, 63);
            this._PictureCleaner.TabIndex = 0;
            this._PictureCleaner.TabStop = false;
            this._PictureCleaner.Click += new System.EventHandler(this._PictureCleaner_Click);
            // 
            // AllCollectioin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 519);
            this.Controls.Add(this._pnlHome);
            this.Controls.Add(this._pnlIconContainer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this._AllCollectionProgressBar);
            this.Controls.Add(this.PicFooter);
            this.Controls.Add(this._TopPanel);
            this.Controls.Add(this._PnlTaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllCollectioin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllCollectioin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._PnlTaskBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PicWindowsClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._TopPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.TabWindowsAndApplication.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this._pnlHome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFooter)).EndInit();
            this._pnlIconContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBoxStartup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureCleaner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _PnlTaskBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox _PicWindowsClose;
        private System.Windows.Forms.Panel _TopPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblSizeOfRam;
        private System.Windows.Forms.Label lblWindowsVersion;
        private System.Windows.Forms.Label LblNameofWindows;
        private System.Windows.Forms.Label LblSoftwareVersion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PicFooter;
        private System.Windows.Forms.ProgressBar _AllCollectionProgressBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel _pnlHome;
        private System.Windows.Forms.TabControl TabWindowsAndApplication;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox ChkWindowsList;
        private System.Windows.Forms.CheckedListBox ChkApplicationlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Panel _pnlIconContainer;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox _PictureBoxStartup;
        private System.Windows.Forms.PictureBox _PictureCleaner;
    }
}