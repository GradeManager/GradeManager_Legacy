using System;
using System.Windows.Forms;

namespace gradecalculator
{
    public partial class addSubject : Form
    {
        public addSubject()
        {
            InitializeComponent();
            Design.createRoundedCorners(this);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (addSubjectBx.Text == "")
            {
                MessageBox.Show("Enter a subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (addSubjectBx.Text.Length > 25)
            {
                MessageBox.Show("Enter a shorter subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (var btn in mainWindow.subjectButtons)
            {
                if (btn.Text == addSubjectBx.Text)
                {
                    MessageBox.Show("Subject already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            mainWindow.addSubject(addSubjectBx.Text);
            addSubjectBx.Text = "";
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            addSubjectBx.Text = "";
            this.Close();
        }

        private void addSubject_onload(object sender, EventArgs e)
        {
            Design.createTextboxPreview("Subject", addSubjectBx);
        }
    }
}
