using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradecalculator
{
    public partial class addGrade : Form
    {
        public const double standardGrade = 5;
        public const double standardPercentage = 100;

        Dictionary<double, Color> gradeColors = new Dictionary<double, Color>()
        {
            { 2, Color.DarkRed },
            { 3, Color.Red },
            { 4, Color.Orange },
            { 5, Color.Green },
            { 6, Color.DarkGreen }
        };

        public addGrade()
        {
            InitializeComponent();
            Design.createRoundedCorners(this);
            gradeBx.Value = (decimal)standardGrade;
            percentageBx.Value = (decimal)standardPercentage;
        }
        private void addGrade_Load(object sender, EventArgs e)
        {
            Design.createTextboxPreview("Exam name", examNameBx);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void gradeBx_ValueChanged(object sender, EventArgs e)
        {

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
