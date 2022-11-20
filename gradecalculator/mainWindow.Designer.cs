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
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addSubBtn = new System.Windows.Forms.Button();
            this.removeSubBtn = new System.Windows.Forms.Button();
            this.safeConfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectBx
            // 
            this.subjectBx.AutoScroll = true;
            this.subjectBx.Location = new System.Drawing.Point(12, 12);
            this.subjectBx.Name = "subjectBx";
            this.subjectBx.Size = new System.Drawing.Size(217, 431);
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
            // nameHeader
            // 
            this.nameHeader.Text = "Exam";
            // 
            // gradeHeader
            // 
            this.gradeHeader.Text = "Grade";
            // 
            // percentHeader
            // 
            this.percentHeader.Text = "Percentage";
            // 
            // addSubBtn
            // 
            this.addSubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSubBtn.ForeColor = System.Drawing.Color.White;
            this.addSubBtn.Location = new System.Drawing.Point(12, 449);
            this.addSubBtn.Name = "addSubBtn";
            this.addSubBtn.Size = new System.Drawing.Size(61, 23);
            this.addSubBtn.TabIndex = 3;
            this.addSubBtn.Text = "Add";
            this.addSubBtn.UseVisualStyleBackColor = true;
            this.addSubBtn.Click += new System.EventHandler(this.addSubBtn_Click);
            // 
            // removeSubBtn
            // 
            this.removeSubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeSubBtn.ForeColor = System.Drawing.Color.White;
            this.removeSubBtn.Location = new System.Drawing.Point(79, 449);
            this.removeSubBtn.Name = "removeSubBtn";
            this.removeSubBtn.Size = new System.Drawing.Size(61, 23);
            this.removeSubBtn.TabIndex = 4;
            this.removeSubBtn.Text = "Remove";
            this.removeSubBtn.UseVisualStyleBackColor = true;
            this.removeSubBtn.Click += new System.EventHandler(this.removeSubBtn_Click);
            // 
            // safeConfBtn
            // 
            this.safeConfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.safeConfBtn.ForeColor = System.Drawing.Color.White;
            this.safeConfBtn.Location = new System.Drawing.Point(146, 449);
            this.safeConfBtn.Name = "safeConfBtn";
            this.safeConfBtn.Size = new System.Drawing.Size(65, 23);
            this.safeConfBtn.TabIndex = 5;
            this.safeConfBtn.Text = "Safe";
            this.safeConfBtn.UseVisualStyleBackColor = true;
            this.safeConfBtn.Click += new System.EventHandler(this.safeConfBtn_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(866, 484);
            this.Controls.Add(this.safeConfBtn);
            this.Controls.Add(this.removeSubBtn);
            this.Controls.Add(this.addSubBtn);
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
        private System.Windows.Forms.Button addSubBtn;
        private System.Windows.Forms.Button removeSubBtn;
        private System.Windows.Forms.Button safeConfBtn;
    }
}

