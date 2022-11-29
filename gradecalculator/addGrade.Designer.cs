namespace GradeManager
{
    partial class addGrade
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
            this.addGradeLbl = new System.Windows.Forms.Label();
            this.examNameBx = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.gradeBx = new System.Windows.Forms.NumericUpDown();
            this.percentageBx = new System.Windows.Forms.NumericUpDown();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.percentageLbl = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBx)).BeginInit();
            this.SuspendLayout();
            // 
            // addGradeLbl
            // 
            this.addGradeLbl.AutoSize = true;
            this.addGradeLbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.addGradeLbl.ForeColor = System.Drawing.Color.Black;
            this.addGradeLbl.Location = new System.Drawing.Point(47, 27);
            this.addGradeLbl.Name = "addGradeLbl";
            this.addGradeLbl.Size = new System.Drawing.Size(80, 18);
            this.addGradeLbl.TabIndex = 4;
            this.addGradeLbl.Text = "Add Grade";
            // 
            // examNameBx
            // 
            this.examNameBx.Location = new System.Drawing.Point(39, 68);
            this.examNameBx.Name = "examNameBx";
            this.examNameBx.Size = new System.Drawing.Size(103, 20);
            this.examNameBx.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(11, 199);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmBtn.Location = new System.Drawing.Point(103, 199);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // gradeBx
            // 
            this.gradeBx.DecimalPlaces = 2;
            this.gradeBx.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.gradeBx.Location = new System.Drawing.Point(97, 94);
            this.gradeBx.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.gradeBx.Name = "gradeBx";
            this.gradeBx.Size = new System.Drawing.Size(45, 20);
            this.gradeBx.TabIndex = 1;
            this.gradeBx.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gradeBx.ValueChanged += new System.EventHandler(this.gradeBx_ValueChanged);
            // 
            // percentageBx
            // 
            this.percentageBx.Location = new System.Drawing.Point(103, 120);
            this.percentageBx.Name = "percentageBx";
            this.percentageBx.Size = new System.Drawing.Size(39, 20);
            this.percentageBx.TabIndex = 2;
            this.percentageBx.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Location = new System.Drawing.Point(36, 96);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(36, 13);
            this.gradeLbl.TabIndex = 12;
            this.gradeLbl.Text = "Grade";
            // 
            // percentageLbl
            // 
            this.percentageLbl.AutoSize = true;
            this.percentageLbl.Location = new System.Drawing.Point(36, 122);
            this.percentageLbl.Name = "percentageLbl";
            this.percentageLbl.Size = new System.Drawing.Size(62, 13);
            this.percentageLbl.TabIndex = 13;
            this.percentageLbl.Text = "Percentage";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(39, 146);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(103, 18);
            this.datePicker.TabIndex = 14;
            this.datePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // addGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 234);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.percentageLbl);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.percentageBx);
            this.Controls.Add(this.gradeBx);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.examNameBx);
            this.Controls.Add(this.addGradeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addGrade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addGrade";
            this.Load += new System.EventHandler(this.addGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addGradeLbl;
        private System.Windows.Forms.TextBox examNameBx;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.NumericUpDown gradeBx;
        private System.Windows.Forms.NumericUpDown percentageBx;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.Label percentageLbl;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}