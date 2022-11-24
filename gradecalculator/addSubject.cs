using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gradecalculator
{
    public partial class addSubject : Form
    {
        public addSubject()
        {
            InitializeComponent();
            Design.createRoundedCorners(this);
        }
        private void addSubject_onload(object sender, EventArgs e)
        {
            Design.createTextboxPreview("Subject", addSubjectBx);
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!checkSubject(addSubjectBx.Text))
                return;

            mainWindow.Jsubjects.Add(new JProperty(addSubjectBx.Text, new JObject()));
            addSubjectBx.Text = "";
            this.Close();
        }

        private bool checkSubject(string subject)
        {
            if (subject == "")
            {
                MessageBox.Show("Enter a subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (subject.Length > 25)
            {
                MessageBox.Show("Enter a shorter subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (var btn in mainWindow.subjectButtons)
            {
                if (btn.Text == subject)
                {
                    MessageBox.Show("Subject already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            addSubjectBx.Text = "";
            this.Close();
        }
    }
}
