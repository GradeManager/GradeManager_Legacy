namespace gradecalculator
{
    partial class removeSubject
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
            this.removeSubjectLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.selectSubjectBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // removeSubjectLbl
            // 
            this.removeSubjectLbl.AutoSize = true;
            this.removeSubjectLbl.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSubjectLbl.ForeColor = System.Drawing.Color.Black;
            this.removeSubjectLbl.Location = new System.Drawing.Point(35, 22);
            this.removeSubjectLbl.Name = "removeSubjectLbl";
            this.removeSubjectLbl.Size = new System.Drawing.Size(123, 19);
            this.removeSubjectLbl.TabIndex = 7;
            this.removeSubjectLbl.Text = "Remove Subject";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(12, 114);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmBtn.Location = new System.Drawing.Point(104, 114);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // selectSubjectBx
            // 
            this.selectSubjectBx.FormattingEnabled = true;
            this.selectSubjectBx.Location = new System.Drawing.Point(26, 56);
            this.selectSubjectBx.Name = "selectSubjectBx";
            this.selectSubjectBx.Size = new System.Drawing.Size(135, 21);
            this.selectSubjectBx.TabIndex = 8;
            this.selectSubjectBx.DropDown += new System.EventHandler(this.selectSubjectbx_dropdown);
            // 
            // removeSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(191, 158);
            this.Controls.Add(this.selectSubjectBx);
            this.Controls.Add(this.removeSubjectLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "removeSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "removeSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label removeSubjectLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ComboBox selectSubjectBx;
    }
}