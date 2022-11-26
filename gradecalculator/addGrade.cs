using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gradecalculator
{
    public partial class addGrade : Form
    {
        public const double standardGrade = 5;
        public const double standardPercentage = 100;

        Dictionary<double, Color> gradeColors = new Dictionary<double, Color>()
        {
            { 2, Color.FromArgb(204, 0, 0) },
            { 3, Color.FromArgb(255, 0, 0) },
            { 4, Color.FromArgb(255, 102, 0) },
            { 5, Color.FromArgb(51, 204, 51) },
            { 6, Color.FromArgb(0, 179, 0) }
        };

        public addGrade()
        {
            InitializeComponent();
            Design.createRoundedCorners(this);
            gradeBx.Value = (decimal)standardGrade;
            percentageBx.Value = (decimal)standardPercentage;
            changeGradeBxColor();
        }

        private void addGrade_Load(object sender, EventArgs e)
        {
            Design.createTextboxPreview("Exam name", examNameBx);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!checkExamname(examNameBx.Text))
                return;
            if (!addExamToJSON(examNameBx.Text, (double)gradeBx.Value, (int)percentageBx.Value, datePicker.Value))
                return;
            //Rewrap Body
            mainWindow.selectedSubject.getExamesFromConfig();

            gradeBx.Value = (decimal)standardGrade;
            percentageBx.Value = (decimal)standardPercentage;
            examNameBx.Text = "";
            this.Close();
        }

        private bool addExamToJSON(string examname, double grade, int percentage, DateTime date)
        {
            if (!(mainWindow.selectedSubject == null || mainWindow.selectedSubject.Jsubject == null))
            {
                JProperty Jexam = new JProperty(examname, new JObject(
                    new JProperty(mainWindow.JgradeString, grade),
                    new JProperty(mainWindow.JpercentageString, percentage),
                    new JProperty(mainWindow.JdateString, date)
                ));
                mainWindow.selectedSubject.Jsubject.Add(Jexam);
                return true;
            }
            else
            {
                MessageBox.Show("Failed to add grade\r\nError: Select a subject", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool checkExamname(string examname)
        {
            if (examname == "")
            {
                MessageBox.Show("Enter a subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (examname.Length > 25)
            {
                MessageBox.Show("Enter a shorter subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void gradeBx_ValueChanged(object sender, EventArgs e)
        {
            if (!changeGradeBxColor())
            {
                //there could be an entry in a log file here
                return;
            }
        }

        private bool changeGradeBxColor()
        {
            double closestGrade = MSKMath.getClosestDouble((double)gradeBx.Value, gradeColors.Keys.ToList<double>())[0];

            Color colr;

            if (!gradeColors.TryGetValue(closestGrade, out colr))
                return false;

            gradeBx.BackColor = colr;
            return true;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            gradeBx.Value = (decimal)standardGrade;
            percentageBx.Value = (decimal)standardPercentage;
            examNameBx.Text = "";
            this.Close();
        }
    }
}
