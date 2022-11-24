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

        private void InitializeCustomComponent()
        {
            //Init Eventhandlers for contextmenu
            this.cM_safeBtn.Click += CM_safeBtn_Click;
            this.cM_AddBtn.Click += CM_AddBtn_Click;
            this.cM_RemoveBtn.Click += CM_RemoveBtn_Click;
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.subjectBx = new System.Windows.Forms.Panel();
            this.gradeList = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addSubBtn = new System.Windows.Forms.Button();
            this.removeSubBtn = new System.Windows.Forms.Button();
            this.safeConfBtn = new System.Windows.Forms.Button();
            this.mW_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cM_safeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.cM_AddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.cM_RemoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.remGradeBtn = new System.Windows.Forms.Button();
            this.addGradeBtn = new System.Windows.Forms.Button();
            this.mW_contextMenu.SuspendLayout();
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
            this.gradeList.Location = new System.Drawing.Point(427, 12);
            this.gradeList.Name = "gradeList";
            this.gradeList.Scrollable = false;
            this.gradeList.Size = new System.Drawing.Size(427, 431);
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
            this.addSubBtn.Image = ((System.Drawing.Image)(resources.GetObject("addSubBtn.Image")));
            this.addSubBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSubBtn.Location = new System.Drawing.Point(12, 449);
            this.addSubBtn.Name = "addSubBtn";
            this.addSubBtn.Size = new System.Drawing.Size(50, 23);
            this.addSubBtn.TabIndex = 3;
            this.addSubBtn.Text = "Add";
            this.addSubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addSubBtn.UseVisualStyleBackColor = true;
            this.addSubBtn.Click += new System.EventHandler(this.addSubBtn_Click);
            // 
            // removeSubBtn
            // 
            this.removeSubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeSubBtn.ForeColor = System.Drawing.Color.White;
            this.removeSubBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeSubBtn.Image")));
            this.removeSubBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeSubBtn.Location = new System.Drawing.Point(68, 449);
            this.removeSubBtn.Name = "removeSubBtn";
            this.removeSubBtn.Size = new System.Drawing.Size(72, 23);
            this.removeSubBtn.TabIndex = 4;
            this.removeSubBtn.Text = "Remove";
            this.removeSubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSubBtn.UseVisualStyleBackColor = true;
            this.removeSubBtn.Click += new System.EventHandler(this.removeSubBtn_Click);
            // 
            // safeConfBtn
            // 
            this.safeConfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.safeConfBtn.ForeColor = System.Drawing.Color.White;
            this.safeConfBtn.Image = ((System.Drawing.Image)(resources.GetObject("safeConfBtn.Image")));
            this.safeConfBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.safeConfBtn.Location = new System.Drawing.Point(146, 449);
            this.safeConfBtn.Name = "safeConfBtn";
            this.safeConfBtn.Size = new System.Drawing.Size(56, 23);
            this.safeConfBtn.TabIndex = 5;
            this.safeConfBtn.Text = "Safe";
            this.safeConfBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.safeConfBtn.UseVisualStyleBackColor = true;
            this.safeConfBtn.Click += new System.EventHandler(this.safeConfBtn_Click);
            // 
            // mW_contextMenu
            // 
            this.mW_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cM_safeBtn,
            this.cM_sep1,
            this.cM_AddBtn,
            this.cM_sep2,
            this.cM_RemoveBtn});
            this.mW_contextMenu.Name = "contextMenu";
            this.mW_contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mW_contextMenu.Size = new System.Drawing.Size(160, 82);
            // 
            // cM_safeBtn
            // 
            this.cM_safeBtn.Image = ((System.Drawing.Image)(resources.GetObject("cM_safeBtn.Image")));
            this.cM_safeBtn.Name = "cM_safeBtn";
            this.cM_safeBtn.Size = new System.Drawing.Size(159, 22);
            this.cM_safeBtn.Text = "Safe";
            // 
            // cM_sep1
            // 
            this.cM_sep1.Name = "cM_sep1";
            this.cM_sep1.Size = new System.Drawing.Size(156, 6);
            // 
            // cM_AddBtn
            // 
            this.cM_AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("cM_AddBtn.Image")));
            this.cM_AddBtn.Name = "cM_AddBtn";
            this.cM_AddBtn.Size = new System.Drawing.Size(159, 22);
            this.cM_AddBtn.Text = "Add Subject";
            // 
            // cM_sep2
            // 
            this.cM_sep2.Name = "cM_sep2";
            this.cM_sep2.Size = new System.Drawing.Size(156, 6);
            // 
            // cM_RemoveBtn
            // 
            this.cM_RemoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("cM_RemoveBtn.Image")));
            this.cM_RemoveBtn.Name = "cM_RemoveBtn";
            this.cM_RemoveBtn.Size = new System.Drawing.Size(159, 22);
            this.cM_RemoveBtn.Text = "Remove Subject";
            // 
            // remGradeBtn
            // 
            this.remGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remGradeBtn.ForeColor = System.Drawing.Color.White;
            this.remGradeBtn.Image = ((System.Drawing.Image)(resources.GetObject("remGradeBtn.Image")));
            this.remGradeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remGradeBtn.Location = new System.Drawing.Point(751, 449);
            this.remGradeBtn.Name = "remGradeBtn";
            this.remGradeBtn.Size = new System.Drawing.Size(103, 23);
            this.remGradeBtn.TabIndex = 7;
            this.remGradeBtn.Text = "Remove Grade";
            this.remGradeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remGradeBtn.UseVisualStyleBackColor = true;
            this.remGradeBtn.Click += new System.EventHandler(this.remGradeBtn_Click);
            // 
            // addGradeBtn
            // 
            this.addGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addGradeBtn.ForeColor = System.Drawing.Color.White;
            this.addGradeBtn.Image = ((System.Drawing.Image)(resources.GetObject("addGradeBtn.Image")));
            this.addGradeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGradeBtn.Location = new System.Drawing.Point(427, 449);
            this.addGradeBtn.Name = "addGradeBtn";
            this.addGradeBtn.Size = new System.Drawing.Size(84, 23);
            this.addGradeBtn.TabIndex = 6;
            this.addGradeBtn.Text = "Add Grade";
            this.addGradeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addGradeBtn.UseVisualStyleBackColor = true;
            this.addGradeBtn.Click += new System.EventHandler(this.addGradeBtn_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(866, 484);
            this.ContextMenuStrip = this.mW_contextMenu;
            this.Controls.Add(this.remGradeBtn);
            this.Controls.Add(this.addGradeBtn);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mW_KeyDown);
            this.mW_contextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip mW_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cM_safeBtn;
        private System.Windows.Forms.ToolStripMenuItem cM_AddBtn;
        private System.Windows.Forms.ToolStripMenuItem cM_RemoveBtn;
        private System.Windows.Forms.ToolStripSeparator cM_sep1;
        private System.Windows.Forms.ToolStripSeparator cM_sep2;
        private System.Windows.Forms.Button remGradeBtn;
        private System.Windows.Forms.Button addGradeBtn;
    }
}

