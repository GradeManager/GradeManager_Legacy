namespace GradeManager
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
            this.cM_AddGrade.Click += CM_AddGrade_Click; ;
            this.cM_RemoveGrade.Click += CM_RemoveGrade_Click;

            this.dropDownPanel.Height = panelNormalHeight;
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
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mW_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cM_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.cM_sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.cM_sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.cM_sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.dropDownPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogJson = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cM_safeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_AddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_AddGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_RemoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_RemoveGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.previewConfBtn = new System.Windows.Forms.Button();
            this.importConfBtn = new System.Windows.Forms.Button();
            this.dropDownBtn = new System.Windows.Forms.Button();
            this.exportConfBtn = new System.Windows.Forms.Button();
            this.autoSafeModeBtn = new System.Windows.Forms.Button();
            this.exportCSVBtn = new System.Windows.Forms.Button();
            this.averageAllLbl = new System.Windows.Forms.Label();
            this.averageCurLbl = new System.Windows.Forms.Label();
            this.plusPointLbl = new System.Windows.Forms.Label();
            this.averageAllTextLbl = new System.Windows.Forms.Label();
            this.plusPointTextLbl = new System.Windows.Forms.Label();
            this.averageCurTextLbl = new System.Windows.Forms.Label();
            this.mW_contextMenu.SuspendLayout();
            this.dropDownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectBx
            // 
            this.subjectBx.AutoScroll = true;
            this.subjectBx.Location = new System.Drawing.Point(12, 41);
            this.subjectBx.Name = "subjectBx";
            this.subjectBx.Size = new System.Drawing.Size(217, 415);
            this.subjectBx.TabIndex = 1;
            // 
            // gradeList
            // 
            this.gradeList.BackColor = System.Drawing.Color.White;
            this.gradeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.gradeHeader,
            this.percentHeader,
            this.dateHeader});
            this.gradeList.HideSelection = false;
            this.gradeList.Location = new System.Drawing.Point(392, 41);
            this.gradeList.Name = "gradeList";
            this.gradeList.Scrollable = false;
            this.gradeList.Size = new System.Drawing.Size(450, 415);
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
            // dateHeader
            // 
            this.dateHeader.Text = "Date";
            // 
            // mW_contextMenu
            // 
            this.mW_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cM_safeBtn,
            this.cM_sep1,
            this.cM_AddBtn,
            this.cM_sep2,
            this.cM_AddGrade,
            this.cM_sep3,
            this.cM_RemoveBtn,
            this.cM_sep4,
            this.cM_RemoveGrade});
            this.mW_contextMenu.Name = "contextMenu";
            this.mW_contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mW_contextMenu.Size = new System.Drawing.Size(160, 138);
            // 
            // cM_sep1
            // 
            this.cM_sep1.Name = "cM_sep1";
            this.cM_sep1.Size = new System.Drawing.Size(156, 6);
            // 
            // cM_sep2
            // 
            this.cM_sep2.Name = "cM_sep2";
            this.cM_sep2.Size = new System.Drawing.Size(156, 6);
            // 
            // cM_sep3
            // 
            this.cM_sep3.Name = "cM_sep3";
            this.cM_sep3.Size = new System.Drawing.Size(156, 6);
            // 
            // cM_sep4
            // 
            this.cM_sep4.Name = "cM_sep4";
            this.cM_sep4.Size = new System.Drawing.Size(156, 6);
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.Color.DimGray;
            this.dropDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropDownPanel.Controls.Add(this.previewConfBtn);
            this.dropDownPanel.Controls.Add(this.importConfBtn);
            this.dropDownPanel.Controls.Add(this.dropDownBtn);
            this.dropDownPanel.Controls.Add(this.exportConfBtn);
            this.dropDownPanel.Controls.Add(this.autoSafeModeBtn);
            this.dropDownPanel.Controls.Add(this.exportCSVBtn);
            this.dropDownPanel.Location = new System.Drawing.Point(12, 12);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(119, 138);
            this.dropDownPanel.TabIndex = 9;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "grades.csv";
            this.saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialogJson
            // 
            this.saveFileDialogJson.FileName = "config.json";
            this.saveFileDialogJson.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            this.saveFileDialogJson.RestoreDirectory = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "json files (config.json)|config.json";
            // 
            // cM_safeBtn
            // 
            this.cM_safeBtn.Image = ((System.Drawing.Image)(resources.GetObject("cM_safeBtn.Image")));
            this.cM_safeBtn.Name = "cM_safeBtn";
            this.cM_safeBtn.Size = new System.Drawing.Size(159, 22);
            this.cM_safeBtn.Text = "Safe";
            // 
            // cM_AddBtn
            // 
            this.cM_AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("cM_AddBtn.Image")));
            this.cM_AddBtn.Name = "cM_AddBtn";
            this.cM_AddBtn.Size = new System.Drawing.Size(159, 22);
            this.cM_AddBtn.Text = "Add Subject";
            // 
            // cM_AddGrade
            // 
            this.cM_AddGrade.Image = ((System.Drawing.Image)(resources.GetObject("cM_AddGrade.Image")));
            this.cM_AddGrade.Name = "cM_AddGrade";
            this.cM_AddGrade.Size = new System.Drawing.Size(159, 22);
            this.cM_AddGrade.Text = "Add Grade";
            // 
            // cM_RemoveBtn
            // 
            this.cM_RemoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("cM_RemoveBtn.Image")));
            this.cM_RemoveBtn.Name = "cM_RemoveBtn";
            this.cM_RemoveBtn.Size = new System.Drawing.Size(159, 22);
            this.cM_RemoveBtn.Text = "Remove Subject";
            // 
            // cM_RemoveGrade
            // 
            this.cM_RemoveGrade.Image = ((System.Drawing.Image)(resources.GetObject("cM_RemoveGrade.Image")));
            this.cM_RemoveGrade.Name = "cM_RemoveGrade";
            this.cM_RemoveGrade.Size = new System.Drawing.Size(159, 22);
            this.cM_RemoveGrade.Text = "Remove Grade";
            // 
            // previewConfBtn
            // 
            this.previewConfBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.previewConfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previewConfBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.previewConfBtn.FlatAppearance.BorderSize = 0;
            this.previewConfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewConfBtn.ForeColor = System.Drawing.Color.Black;
            this.previewConfBtn.Image = global::GradeManager.Properties.Resources.preview;
            this.previewConfBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.previewConfBtn.Location = new System.Drawing.Point(0, 93);
            this.previewConfBtn.Name = "previewConfBtn";
            this.previewConfBtn.Size = new System.Drawing.Size(119, 23);
            this.previewConfBtn.TabIndex = 12;
            this.previewConfBtn.Text = "Preview config";
            this.previewConfBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.previewConfBtn.UseVisualStyleBackColor = false;
            this.previewConfBtn.Click += new System.EventHandler(this.previewConfBtn_Click);
            // 
            // importConfBtn
            // 
            this.importConfBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.importConfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importConfBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.importConfBtn.FlatAppearance.BorderSize = 0;
            this.importConfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importConfBtn.ForeColor = System.Drawing.Color.Black;
            this.importConfBtn.Image = global::GradeManager.Properties.Resources.import;
            this.importConfBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importConfBtn.Location = new System.Drawing.Point(0, 70);
            this.importConfBtn.Name = "importConfBtn";
            this.importConfBtn.Size = new System.Drawing.Size(119, 23);
            this.importConfBtn.TabIndex = 11;
            this.importConfBtn.Text = "Import config";
            this.importConfBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importConfBtn.UseVisualStyleBackColor = false;
            this.importConfBtn.Click += new System.EventHandler(this.importConfBtn_Click);
            // 
            // dropDownBtn
            // 
            this.dropDownBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropDownBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropDownBtn.FlatAppearance.BorderSize = 0;
            this.dropDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDownBtn.ForeColor = System.Drawing.Color.Black;
            this.dropDownBtn.Image = global::GradeManager.Properties.Resources.menu_dots;
            this.dropDownBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropDownBtn.Location = new System.Drawing.Point(0, 0);
            this.dropDownBtn.Name = "dropDownBtn";
            this.dropDownBtn.Size = new System.Drawing.Size(119, 24);
            this.dropDownBtn.TabIndex = 0;
            this.dropDownBtn.Text = "Options";
            this.dropDownBtn.UseVisualStyleBackColor = false;
            this.dropDownBtn.Click += new System.EventHandler(this.dropDownBtn_Click);
            // 
            // exportConfBtn
            // 
            this.exportConfBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exportConfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportConfBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportConfBtn.FlatAppearance.BorderSize = 0;
            this.exportConfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportConfBtn.ForeColor = System.Drawing.Color.Black;
            this.exportConfBtn.Image = global::GradeManager.Properties.Resources.config;
            this.exportConfBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportConfBtn.Location = new System.Drawing.Point(0, 24);
            this.exportConfBtn.Name = "exportConfBtn";
            this.exportConfBtn.Size = new System.Drawing.Size(119, 23);
            this.exportConfBtn.TabIndex = 10;
            this.exportConfBtn.Text = "Export config";
            this.exportConfBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportConfBtn.UseVisualStyleBackColor = false;
            this.exportConfBtn.Click += new System.EventHandler(this.exportConfBtn_Click);
            // 
            // autoSafeModeBtn
            // 
            this.autoSafeModeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.autoSafeModeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoSafeModeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoSafeModeBtn.FlatAppearance.BorderSize = 0;
            this.autoSafeModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoSafeModeBtn.ForeColor = System.Drawing.Color.Black;
            this.autoSafeModeBtn.Image = global::GradeManager.Properties.Resources.disable;
            this.autoSafeModeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoSafeModeBtn.Location = new System.Drawing.Point(0, 116);
            this.autoSafeModeBtn.Name = "autoSafeModeBtn";
            this.autoSafeModeBtn.Size = new System.Drawing.Size(119, 23);
            this.autoSafeModeBtn.TabIndex = 5;
            this.autoSafeModeBtn.Text = "Auto safe";
            this.autoSafeModeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autoSafeModeBtn.UseVisualStyleBackColor = false;
            this.autoSafeModeBtn.Click += new System.EventHandler(this.autoSafeModeBtn_Click);
            // 
            // exportCSVBtn
            // 
            this.exportCSVBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exportCSVBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportCSVBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportCSVBtn.FlatAppearance.BorderSize = 0;
            this.exportCSVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportCSVBtn.ForeColor = System.Drawing.Color.Black;
            this.exportCSVBtn.Image = global::GradeManager.Properties.Resources.export;
            this.exportCSVBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportCSVBtn.Location = new System.Drawing.Point(0, 47);
            this.exportCSVBtn.Name = "exportCSVBtn";
            this.exportCSVBtn.Size = new System.Drawing.Size(119, 23);
            this.exportCSVBtn.TabIndex = 7;
            this.exportCSVBtn.Text = "Export CSV";
            this.exportCSVBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportCSVBtn.UseVisualStyleBackColor = false;
            this.exportCSVBtn.Click += new System.EventHandler(this.exportCSVBtn_Click);
            // 
            // averageAllLbl
            // 
            this.averageAllLbl.AutoSize = true;
            this.averageAllLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.averageAllLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.averageAllLbl.Location = new System.Drawing.Point(129, 459);
            this.averageAllLbl.Name = "averageAllLbl";
            this.averageAllLbl.Size = new System.Drawing.Size(14, 14);
            this.averageAllLbl.TabIndex = 10;
            this.averageAllLbl.Text = "0";
            // 
            // averageCurLbl
            // 
            this.averageCurLbl.AutoSize = true;
            this.averageCurLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageCurLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.averageCurLbl.Location = new System.Drawing.Point(472, 460);
            this.averageCurLbl.Name = "averageCurLbl";
            this.averageCurLbl.Size = new System.Drawing.Size(14, 14);
            this.averageCurLbl.TabIndex = 11;
            this.averageCurLbl.Text = "0";
            // 
            // plusPointLbl
            // 
            this.plusPointLbl.AutoSize = true;
            this.plusPointLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.plusPointLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.plusPointLbl.Location = new System.Drawing.Point(129, 476);
            this.plusPointLbl.Name = "plusPointLbl";
            this.plusPointLbl.Size = new System.Drawing.Size(14, 14);
            this.plusPointLbl.TabIndex = 12;
            this.plusPointLbl.Text = "0";
            // 
            // averageAllTextLbl
            // 
            this.averageAllTextLbl.AutoSize = true;
            this.averageAllTextLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.averageAllTextLbl.Location = new System.Drawing.Point(12, 459);
            this.averageAllTextLbl.Name = "averageAllTextLbl";
            this.averageAllTextLbl.Size = new System.Drawing.Size(114, 13);
            this.averageAllTextLbl.TabIndex = 13;
            this.averageAllTextLbl.Text = "Average grade overall:";
            // 
            // plusPointTextLbl
            // 
            this.plusPointTextLbl.AutoSize = true;
            this.plusPointTextLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.plusPointTextLbl.Location = new System.Drawing.Point(12, 477);
            this.plusPointTextLbl.Name = "plusPointTextLbl";
            this.plusPointTextLbl.Size = new System.Drawing.Size(92, 13);
            this.plusPointTextLbl.TabIndex = 14;
            this.plusPointTextLbl.Text = "Pluspoints overall:";
            // 
            // averageCurTextLbl
            // 
            this.averageCurTextLbl.AutoSize = true;
            this.averageCurTextLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.averageCurTextLbl.Location = new System.Drawing.Point(389, 460);
            this.averageCurTextLbl.Name = "averageCurTextLbl";
            this.averageCurTextLbl.Size = new System.Drawing.Size(80, 13);
            this.averageCurTextLbl.TabIndex = 15;
            this.averageCurTextLbl.Text = "Average grade:";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 499);
            this.ContextMenuStrip = this.mW_contextMenu;
            this.Controls.Add(this.averageCurTextLbl);
            this.Controls.Add(this.plusPointTextLbl);
            this.Controls.Add(this.averageAllTextLbl);
            this.Controls.Add(this.plusPointLbl);
            this.Controls.Add(this.averageCurLbl);
            this.Controls.Add(this.averageAllLbl);
            this.Controls.Add(this.dropDownPanel);
            this.Controls.Add(this.gradeList);
            this.Controls.Add(this.subjectBx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Manager";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mW_KeyDown);
            this.mW_contextMenu.ResumeLayout(false);
            this.dropDownPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel subjectBx;
        private System.Windows.Forms.ListView gradeList;
        private System.Windows.Forms.ColumnHeader percentHeader;
        private System.Windows.Forms.ColumnHeader gradeHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.Button autoSafeModeBtn;
        private System.Windows.Forms.ContextMenuStrip mW_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cM_safeBtn;
        private System.Windows.Forms.ToolStripMenuItem cM_AddBtn;
        private System.Windows.Forms.ToolStripMenuItem cM_RemoveBtn;
        private System.Windows.Forms.ToolStripSeparator cM_sep1;
        private System.Windows.Forms.ToolStripSeparator cM_sep2;
        private System.Windows.Forms.Button exportCSVBtn;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.Panel dropDownPanel;
        private System.Windows.Forms.Button dropDownBtn;
        private System.Windows.Forms.ToolStripMenuItem cM_AddGrade;
        private System.Windows.Forms.ToolStripSeparator cM_sep3;
        private System.Windows.Forms.ToolStripSeparator cM_sep4;
        private System.Windows.Forms.ToolStripMenuItem cM_RemoveGrade;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button exportConfBtn;
        private System.Windows.Forms.Button importConfBtn;
        private System.Windows.Forms.Button previewConfBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogJson;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label averageAllLbl;
        private System.Windows.Forms.Label averageCurLbl;
        private System.Windows.Forms.Label plusPointLbl;
        private System.Windows.Forms.Label averageAllTextLbl;
        private System.Windows.Forms.Label plusPointTextLbl;
        private System.Windows.Forms.Label averageCurTextLbl;
    }
}

