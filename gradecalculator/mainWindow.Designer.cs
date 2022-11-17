namespace gradecalculator
{
    partial class mainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectBx = new System.Windows.Forms.Panel();
            this.gradeList = new System.Windows.Forms.ListView();
            this.percentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // subjectBx
            // 
            this.subjectBx.AutoScroll = true;
            this.subjectBx.Location = new System.Drawing.Point(12, 12);
            this.subjectBx.Name = "subjectBx";
            this.subjectBx.Size = new System.Drawing.Size(217, 460);
            this.subjectBx.TabIndex = 1;
            // 
            // gradeList
            // 
            this.gradeList.BackColor = System.Drawing.Color.White;
            this.gradeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.gradeHeader,
            this.percentHeader});
            this.gradeList.HideSelection = false;
            this.gradeList.Location = new System.Drawing.Point(426, 12);
            this.gradeList.Name = "gradeList";
            this.gradeList.Scrollable = false;
            this.gradeList.Size = new System.Drawing.Size(428, 460);
            this.gradeList.TabIndex = 2;
            this.gradeList.UseCompatibleStateImageBehavior = false;
            this.gradeList.View = System.Windows.Forms.View.Details;
            // 
            // percentHeader
            // 
            this.percentHeader.Text = "Percentage";
            // 
            // gradeHeader
            // 
            this.gradeHeader.Text = "Grade";
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Exam";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(866, 484);
            this.Controls.Add(this.gradeList);
            this.Controls.Add(this.subjectBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subjectBx;
        private System.Windows.Forms.ListView gradeList;
        private System.Windows.Forms.ColumnHeader percentHeader;
        private System.Windows.Forms.ColumnHeader gradeHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
    }
}

