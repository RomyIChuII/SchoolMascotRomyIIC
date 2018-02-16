namespace SchoolMascotRomyIIC
{
    partial class frmSchoolMascot
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
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBellHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMark = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStPaul = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolsToolStripMenuItem});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(625, 24);
            this.mnuSchools.TabIndex = 0;
            this.mnuSchools.Text = "Schools";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Monospac821 BT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(12, 88);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(131, 39);
            this.lblSchoolName.TabIndex = 1;
            this.lblSchoolName.Text = "label1";
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Font = new System.Drawing.Font("Monospac821 BT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolMascot.Location = new System.Drawing.Point(12, 157);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(131, 39);
            this.lblSchoolMascot.TabIndex = 2;
            this.lblSchoolMascot.Text = "label2";
            // 
            // schoolsToolStripMenuItem
            // 
            this.schoolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniBellHigh,
            this.mniStMark,
            this.mniStPaul});
            this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
            this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.schoolsToolStripMenuItem.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniBellHigh
            // 
            this.mniBellHigh.Name = "mniBellHigh";
            this.mniBellHigh.Size = new System.Drawing.Size(152, 22);
            this.mniBellHigh.Text = "Bell High";
            this.mniBellHigh.Click += new System.EventHandler(this.mniBellHigh_Click);
            // 
            // mniStMark
            // 
            this.mniStMark.Name = "mniStMark";
            this.mniStMark.Size = new System.Drawing.Size(152, 22);
            this.mniStMark.Text = "St. Mark";
            this.mniStMark.Click += new System.EventHandler(this.mniStMark_Click);
            // 
            // mniStPaul
            // 
            this.mniStPaul.Name = "mniStPaul";
            this.mniStPaul.Size = new System.Drawing.Size(152, 22);
            this.mniStPaul.Text = "St. Paul";
            this.mniStPaul.Click += new System.EventHandler(this.mniStPaul_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 313);
            this.Controls.Add(this.lblSchoolMascot);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblSchoolMascot;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniBellHigh;
        private System.Windows.Forms.ToolStripMenuItem mniStMark;
        private System.Windows.Forms.ToolStripMenuItem mniStPaul;
    }
}

