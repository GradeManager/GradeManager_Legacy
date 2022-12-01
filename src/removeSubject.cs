using System;
using System.Windows.Forms;

namespace GradeManager
{
    public partial class removeSubject : Form
    {
        public removeSubject()
        {
            InitializeComponent();
            Design.createRoundedCorners(this);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (selectSubjectBx.SelectedItem == null)
            {
                MessageBox.Show("Select a subject", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Remove property from JSON Object
            mainWindow.Jsubjects.Property((string)selectSubjectBx.SelectedItem).Remove();
            selectSubjectBx.SelectedItem = null;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            selectSubjectBx.SelectedItem = null;
            this.Close();
        }

        private void selectSubjectbx_dropdown(object sender, EventArgs e)
        {
            selectSubjectBx.Items.Clear();
            foreach (var btn in mainWindow.subjectButtons)
            {
                selectSubjectBx.Items.Add(btn.Text);
            }
        }
    }
}
