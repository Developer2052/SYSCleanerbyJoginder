namespace syscleaner
{
    partial class ProgramList
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
            this.headerControl1 = new CustomControl.HeaderControl();
            this.GridListOfProgram = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridListOfProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.White;
            this.headerControl1.Location = new System.Drawing.Point(0, 1);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(724, 86);
            this.headerControl1.TabIndex = 0;
            // 
            // GridListOfProgram
            // 
            this.GridListOfProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListOfProgram.Location = new System.Drawing.Point(10, 93);
            this.GridListOfProgram.Name = "GridListOfProgram";
            this.GridListOfProgram.Size = new System.Drawing.Size(704, 398);
            this.GridListOfProgram.TabIndex = 1;
            // 
            // ProgramList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 503);
            this.Controls.Add(this.GridListOfProgram);
            this.Controls.Add(this.headerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramList";
            ((System.ComponentModel.ISupportInitialize)(this.GridListOfProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.HeaderControl headerControl1;
        private System.Windows.Forms.DataGridView GridListOfProgram;
    }
}