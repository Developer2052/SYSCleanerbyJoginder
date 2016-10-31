namespace syscleaner
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.OuterPannel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPercentCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFreeSpaceCount = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.LblAwardWinning = new System.Windows.Forms.Label();
            this.LblFasterComputer = new System.Windows.Forms.Label();
            this.LblQuickerStartup = new System.Windows.Forms.Label();
            this.lblSafeBrowsing = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.headerControl1 = new CustomControl.HeaderControl();
            this.OuterPannel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // OuterPannel
            // 
            this.OuterPannel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OuterPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OuterPannel.Controls.Add(this.panel4);
            this.OuterPannel.Controls.Add(this.panel3);
            this.OuterPannel.Location = new System.Drawing.Point(4, 46);
            this.OuterPannel.Name = "OuterPannel";
            this.OuterPannel.Size = new System.Drawing.Size(719, 460);
            this.OuterPannel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pnlCenter);
            this.panel4.Controls.Add(this.LblAwardWinning);
            this.panel4.Controls.Add(this.LblFasterComputer);
            this.panel4.Controls.Add(this.LblQuickerStartup);
            this.panel4.Controls.Add(this.lblSafeBrowsing);
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 384);
            this.panel4.TabIndex = 2;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.button1);
            this.pnlCenter.Controls.Add(this.lblPercentCount);
            this.pnlCenter.Controls.Add(this.groupBox1);
            this.pnlCenter.Controls.Add(this.pictureBox9);
            this.pnlCenter.Controls.Add(this.pictureBox8);
            this.pnlCenter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pnlCenter.Location = new System.Drawing.Point(3, 94);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(713, 285);
            this.pnlCenter.TabIndex = 8;
            this.pnlCenter.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::syscleaner.Properties.Resources.buttonclean;
            this.button1.Location = new System.Drawing.Point(592, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPercentCount
            // 
            this.lblPercentCount.AutoSize = true;
            this.lblPercentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentCount.Location = new System.Drawing.Point(616, 65);
            this.lblPercentCount.Name = "lblPercentCount";
            this.lblPercentCount.Size = new System.Drawing.Size(49, 22);
            this.lblPercentCount.TabIndex = 5;
            this.lblPercentCount.Text = "COP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFreeSpaceCount);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblFreeSpaceCount
            // 
            this.lblFreeSpaceCount.AutoSize = true;
            this.lblFreeSpaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeSpaceCount.Location = new System.Drawing.Point(410, 16);
            this.lblFreeSpaceCount.Name = "lblFreeSpaceCount";
            this.lblFreeSpaceCount.Size = new System.Drawing.Size(174, 25);
            this.lblFreeSpaceCount.TabIndex = 5;
            this.lblFreeSpaceCount.Text = "TOTAL : 1170 MB";
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Image = global::syscleaner.Properties.Resources.buttonclean;
            this.btnClean.Location = new System.Drawing.Point(203, 22);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(114, 30);
            this.btnClean.TabIndex = 2;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnScan
            // 
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScan.Image = global::syscleaner.Properties.Resources.buttonscan;
            this.btnScan.Location = new System.Drawing.Point(24, 22);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(114, 30);
            this.btnScan.TabIndex = 1;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::syscleaner.Properties.Resources.Double_Circle_Loading;
            this.pictureBox9.Location = new System.Drawing.Point(576, 10);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(130, 125);
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::syscleaner.Properties.Resources.CenterCollection;
            this.pictureBox8.Location = new System.Drawing.Point(0, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(374, 178);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // LblAwardWinning
            // 
            this.LblAwardWinning.AutoSize = true;
            this.LblAwardWinning.Location = new System.Drawing.Point(631, 79);
            this.LblAwardWinning.Name = "LblAwardWinning";
            this.LblAwardWinning.Size = new System.Drawing.Size(79, 13);
            this.LblAwardWinning.TabIndex = 7;
            this.LblAwardWinning.Text = "Award-Winning";
            // 
            // LblFasterComputer
            // 
            this.LblFasterComputer.AutoSize = true;
            this.LblFasterComputer.Location = new System.Drawing.Point(424, 79);
            this.LblFasterComputer.Name = "LblFasterComputer";
            this.LblFasterComputer.Size = new System.Drawing.Size(84, 13);
            this.LblFasterComputer.TabIndex = 6;
            this.LblFasterComputer.Text = "Faster Computer";
            // 
            // LblQuickerStartup
            // 
            this.LblQuickerStartup.AutoSize = true;
            this.LblQuickerStartup.Location = new System.Drawing.Point(209, 79);
            this.LblQuickerStartup.Name = "LblQuickerStartup";
            this.LblQuickerStartup.Size = new System.Drawing.Size(81, 13);
            this.LblQuickerStartup.TabIndex = 5;
            this.LblQuickerStartup.Text = "Quicker Startup";
            // 
            // lblSafeBrowsing
            // 
            this.lblSafeBrowsing.AutoSize = true;
            this.lblSafeBrowsing.Location = new System.Drawing.Point(12, 79);
            this.lblSafeBrowsing.Name = "lblSafeBrowsing";
            this.lblSafeBrowsing.Size = new System.Drawing.Size(75, 13);
            this.lblSafeBrowsing.TabIndex = 4;
            this.lblSafeBrowsing.Text = "Safe Browsing";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::syscleaner.Properties.Resources.icon4;
            this.pictureBox7.Location = new System.Drawing.Point(623, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(93, 88);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::syscleaner.Properties.Resources.icon3;
            this.pictureBox6.Location = new System.Drawing.Point(418, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(93, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::syscleaner.Properties.Resources.icon2;
            this.pictureBox5.Location = new System.Drawing.Point(203, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(93, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::syscleaner.Properties.Resources.icon1;
            this.pictureBox4.Location = new System.Drawing.Point(3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(-1, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 33);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::syscleaner.Properties.Resources.FooterImage;
            this.pictureBox3.Location = new System.Drawing.Point(1, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(716, 37);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.White;
            this.headerControl1.Location = new System.Drawing.Point(4, 2);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(719, 90);
            this.headerControl1.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 507);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.OuterPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Home_Load);
            this.OuterPannel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel OuterPannel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSafeBrowsing;
        private System.Windows.Forms.Label LblAwardWinning;
        private System.Windows.Forms.Label LblFasterComputer;
        private System.Windows.Forms.Label LblQuickerStartup;
        private System.Windows.Forms.GroupBox pnlCenter;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPercentCount;
        private System.Windows.Forms.Label lblFreeSpaceCount;
        private CustomControl.HeaderControl headerControl1;
        private System.Windows.Forms.Button button1;
    }
}
