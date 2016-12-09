namespace syscleaner
{
    partial class CleanAnalyze
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node12", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node18");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node16", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblSizeOfRam = new System.Windows.Forms.Label();
            this.LblSoftwareVersion = new System.Windows.Forms.Label();
            this.lblWindowsVersion = new System.Windows.Forms.Label();
            this.LblNameofWindows = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblHomeAbovePageText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.headerControl1 = new CustomControl.HeaderControl();
            this.PnlContainer = new System.Windows.Forms.GroupBox();
            this.CleanProgressbar = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.PnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblSizeOfRam);
            this.panel2.Controls.Add(this.LblSoftwareVersion);
            this.panel2.Controls.Add(this.lblWindowsVersion);
            this.panel2.Controls.Add(this.LblNameofWindows);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-172, -122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 82);
            this.panel2.TabIndex = 2;
            // 
            // LblSizeOfRam
            // 
            this.LblSizeOfRam.AutoSize = true;
            this.LblSizeOfRam.ForeColor = System.Drawing.Color.White;
            this.LblSizeOfRam.Location = new System.Drawing.Point(21, 36);
            this.LblSizeOfRam.Name = "LblSizeOfRam";
            this.LblSizeOfRam.Size = new System.Drawing.Size(82, 13);
            this.LblSizeOfRam.TabIndex = 5;
            this.LblSizeOfRam.Text = "ProcessorName";
            // 
            // LblSoftwareVersion
            // 
            this.LblSoftwareVersion.AutoSize = true;
            this.LblSoftwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSoftwareVersion.ForeColor = System.Drawing.Color.White;
            this.LblSoftwareVersion.Location = new System.Drawing.Point(424, 56);
            this.LblSoftwareVersion.Name = "LblSoftwareVersion";
            this.LblSoftwareVersion.Size = new System.Drawing.Size(147, 20);
            this.LblSoftwareVersion.TabIndex = 4;
            this.LblSoftwareVersion.Text = "Software Version";
            // 
            // lblWindowsVersion
            // 
            this.lblWindowsVersion.AutoSize = true;
            this.lblWindowsVersion.ForeColor = System.Drawing.Color.White;
            this.lblWindowsVersion.Location = new System.Drawing.Point(21, 15);
            this.lblWindowsVersion.Name = "lblWindowsVersion";
            this.lblWindowsVersion.Size = new System.Drawing.Size(89, 13);
            this.lblWindowsVersion.TabIndex = 2;
            this.lblWindowsVersion.Text = "Windows Version";
            // 
            // LblNameofWindows
            // 
            this.LblNameofWindows.AutoSize = true;
            this.LblNameofWindows.ForeColor = System.Drawing.Color.White;
            this.LblNameofWindows.Location = new System.Drawing.Point(21, 56);
            this.LblNameofWindows.Name = "LblNameofWindows";
            this.LblNameofWindows.Size = new System.Drawing.Size(82, 13);
            this.LblNameofWindows.TabIndex = 1;
            this.LblNameofWindows.Text = "Name of system";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::syscleaner.Properties.Resources.Sys_Clear_With_White_Name;
            this.pictureBox1.Location = new System.Drawing.Point(422, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblHomeAbovePageText);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(-170, -119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 42);
            this.panel1.TabIndex = 3;
            // 
            // LblHomeAbovePageText
            // 
            this.LblHomeAbovePageText.AutoSize = true;
            this.LblHomeAbovePageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHomeAbovePageText.Location = new System.Drawing.Point(44, 11);
            this.LblHomeAbovePageText.Name = "LblHomeAbovePageText";
            this.LblHomeAbovePageText.Size = new System.Drawing.Size(78, 17);
            this.LblHomeAbovePageText.TabIndex = 2;
            this.LblHomeAbovePageText.Text = "Title define";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::syscleaner.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 44);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::syscleaner.Properties.Resources.ClosedButton;
            this.CloseButton.Location = new System.Drawing.Point(582, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(49, 25);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.White;
            this.headerControl1.Location = new System.Drawing.Point(2, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(723, 90);
            this.headerControl1.TabIndex = 4;
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.White;
            this.PnlContainer.Controls.Add(this.treeView1);
            this.PnlContainer.Controls.Add(this.CleanProgressbar);
            this.PnlContainer.Controls.Add(this.pictureBox3);
            this.PnlContainer.Location = new System.Drawing.Point(2, 90);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(727, 494);
            this.PnlContainer.TabIndex = 5;
            this.PnlContainer.TabStop = false;
            // 
            // CleanProgressbar
            // 
            this.CleanProgressbar.Location = new System.Drawing.Point(2, 7);
            this.CleanProgressbar.Name = "CleanProgressbar";
            this.CleanProgressbar.Size = new System.Drawing.Size(721, 21);
            this.CleanProgressbar.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::syscleaner.Properties.Resources.FooterImage;
            this.pictureBox3.Location = new System.Drawing.Point(0, 446);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(727, 47);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.treeView1.Location = new System.Drawing.Point(68, 85);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Node4";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Node10";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Node11";
            treeNode12.Name = "Node8";
            treeNode12.Text = "Node8";
            treeNode13.Name = "Node13";
            treeNode13.Text = "Node13";
            treeNode14.Name = "Node14";
            treeNode14.Text = "Node14";
            treeNode15.Name = "Node15";
            treeNode15.Text = "Node15";
            treeNode16.Name = "Node12";
            treeNode16.Text = "Node12";
            treeNode17.Name = "Node17";
            treeNode17.Text = "Node17";
            treeNode18.Name = "Node18";
            treeNode18.Text = "Node18";
            treeNode19.Name = "Node16";
            treeNode19.Text = "Node16";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16,
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(265, 259);
            this.treeView1.TabIndex = 20;
            // 
            // CleanAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 638);
            this.ControlBox = false;
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CleanAnalyze";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleanAnalyze";
            this.Load += new System.EventHandler(this.CleanAnalyze_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.PnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblSizeOfRam;
        private System.Windows.Forms.Label LblSoftwareVersion;
        private System.Windows.Forms.Label lblWindowsVersion;
        private System.Windows.Forms.Label LblNameofWindows;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHomeAbovePageText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox CloseButton;
        private CustomControl.HeaderControl headerControl1;
        private System.Windows.Forms.GroupBox PnlContainer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar CleanProgressbar;
        private System.Windows.Forms.TreeView treeView1;
    }
}