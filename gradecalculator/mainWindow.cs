using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static gradecalculator.Subject;

namespace gradecalculator
{
    public partial class mainWindow : Form
    {

        public static JObject file { get; set; }
        public static JObject Jsubjects { get; set; }
        public static List<Subject> subjectButtons { get; set; } = new List<Subject>();

        public static addSubject aS { get; } = new addSubject();
        public static removeSubject rS { get; } = new removeSubject();
        public static addGrade aG { get; } = new addGrade();

        public static Subject selectedSubject { get; set; }

        private static JValue Jautosafemode { get; set; }

        public const string JgradeString = "grade";
        public const string JpercentageString = "percentage";

        private const double opacity = 1;
        private const int panelNormalHeight = 26;
        private const int panelExpandedHeight = 138;


        public mainWindow()
        {
            InitializeComponent();
            InitializeCustomComponent();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            this.Opacity = opacity;
            this.KeyPreview = true;
            gradeHeader.Width = 80;
            percentHeader.Width = 80;
            dateHeader.Width = 120;
            nameHeader.Width = gradeList.Width - percentHeader.Width - gradeHeader.Width - dateHeader.Width;
            if (!deserializeJsonConfig())
                Application.Exit();
            getSubjectsFromConfig();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig();
            else
            {
                var msgBtns = MessageBox.Show("Safe changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msgBtns == DialogResult.Yes)
                    serializeJsonConfig();
            }
        }

        private void getSubjectsFromConfig()
        {
            subjectBx.Controls.Clear();
            subjectButtons.Clear();
            //Wrap the subjects
            foreach (var item in Jsubjects)
            {
                createSubButton(item.Key, subjectButtons.Count);
            }
        }

        private bool deserializeJsonConfig()
        {
            if (!File.Exists(GetDirectoryFromExecutable() + "\\config.json"))
            {
                MessageBox.Show("cannot find config.json file\r\n\r\nApplication is terminated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Deserialize JSON file
            using (StreamReader sr = new StreamReader(GetDirectoryFromExecutable() + "\\config.json"))
            {
                //Init JSON variables
                string json = sr.ReadToEnd();
                file = JObject.Parse(json);
                Jsubjects = (JObject)file["subjects"];
                Jautosafemode = (JValue)file["autosafemode"];
            }
            if (!(bool)Jautosafemode.Value)
                autoSafeModeBtn.Image = Properties.Resources.disable;
            else
                autoSafeModeBtn.Image = Properties.Resources.enable;
            return true;
        }

        private bool serializeJsonConfig()
        {
            if (!File.Exists(GetDirectoryFromExecutable() + "\\config.json"))
            {
                MessageBox.Show("cannot find config.json file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                File.WriteAllText(GetDirectoryFromExecutable() + "\\config.json", JsonConvert.SerializeObject(file));
            }
            catch (Exception ex)
            {
                MessageBox.Show("cannot write to config.json file \r\n\r\nError:\r\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string GetDirectoryFromExecutable()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void toggleDropDown()
        {
            if (dropDownPanel.Height == panelExpandedHeight)
            {
                dropDownPanel.Height = panelNormalHeight;
                dropDownBtn.Image = Properties.Resources.menu_dots;
            }
            else
            {
                dropDownPanel.Height = panelExpandedHeight;
                dropDownBtn.Image = Properties.Resources.cross;
            }
        }

        private void toggleAutoSafeMode()
        {
            if (!(bool)Jautosafemode.Value)
            {
                Jautosafemode.Value = true;
                autoSafeModeBtn.Image = Properties.Resources.enable;
            } else
            {
                Jautosafemode.Value = false;
                autoSafeModeBtn.Image = Properties.Resources.disable;
            }
        }

        private void createSubButton(string Subject, int index)
        {
            Subject subject = new Subject(Subject);
            subject.Text = Subject;
            subject.Location = new Point(10, 50 * index + 20);
            subject.Width = 150;
            subject.Height = 40;
            subject.FlatStyle = FlatStyle.Flat;
            subject.ForeColor = Color.White;
            subject.BackColor = Color.Gray;


            subject.Click += (object sender, EventArgs e) =>
            {
                selectedSubject = subject;
                subject.getExamesFromConfig();
                subject.displayExames(gradeList);
            };

            subjectButtons.Add(subject);
            subjectBx.Controls.Add(subject);
        }

        private void addSubject()
        {
            Design.changeItemVisibility(this, false, 0.8);
            aS.ShowDialog();
            Design.changeItemVisibility(this, true, opacity);
            getSubjectsFromConfig();
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig();
        }
        private void removeSubject()
        {
            Design.changeItemVisibility(this, false, 0.8);
            rS.ShowDialog();
            Design.changeItemVisibility(this, true, opacity);
            getSubjectsFromConfig();
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig();
        }
        private void addGrade()
        {
            Design.changeItemVisibility(this, false, 0.8);
            aG.ShowDialog();
            Design.changeItemVisibility(this, true, opacity);
            //Rewrap Body of selectedSubject
            if (selectedSubject != null)
                selectedSubject.displayExames(gradeList);
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig();
        }
        private void removeGrade()
        {
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig();
        }

        //#######--------------------------------------------|
        //Controls--------------------------------------------|
        //#######--------------------------------------------|
        private void addSubBtn_Click(object sender, EventArgs e)
        {
            addSubject();
            toggleDropDown();
            this.ActiveControl = null;
        }

        private void removeSubBtn_Click(object sender, EventArgs e)
        {
            removeSubject();
            toggleDropDown();
            this.ActiveControl = null;
        }

        private void autoSafeModeBtn_Click(object sender, EventArgs e)
        {
            toggleAutoSafeMode();
            this.ActiveControl = null;
        }

        private void addGradeBtn_Click(object sender, EventArgs e)
        {
            addGrade();
            toggleDropDown();
            this.ActiveControl = null;
        }

        private void remGradeBtn_Click(object sender, EventArgs e)
        {
            removeGrade();
            toggleDropDown();
            this.ActiveControl = null;
        }

        private void mW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                serializeJsonConfig();
            }
        }

        private void dropDownBtn_Click(object sender, EventArgs e)
        {
            toggleDropDown();  
        }

        //#######--------------------------------------------|
        //Controls--------------------------------------------|
        //#######--------------------------------------------|


        //####################--------------------------------------------|
        //mW_contextMenu Items--------------------------------------------|
        //####################--------------------------------------------|
        private void CM_safeBtn_Click(object sender, EventArgs e)
        {
            serializeJsonConfig();
        }
        private void CM_AddBtn_Click(object sender, EventArgs e)
        {
            addSubject();
        }

        private void CM_RemoveBtn_Click(object sender, EventArgs e)
        {
            removeSubject();
        }
        //####################--------------------------------------------|
        //mW_contextMenu Items--------------------------------------------|
        //####################--------------------------------------------|
    }

    public class Subject : Button
    {
        public struct Exam
        {
            public string examname { get; set; }
            public double grade { get; set; }
            public int percentage { get; set; }
        }

        public List<Exam> exames { get; set; }
        public JObject Jsubject { get; set; }
        public Subject(string subject)
        {
            exames = new List<Exam>();
            Jsubject = (JObject)mainWindow.Jsubjects[subject];

            getExamesFromConfig();
        }

        /// <summary>
        /// Rewraps the Exam list of this subject with the virtual config
        /// </summary>
        /// <returns>Result</returns>
        public bool getExamesFromConfig()
        {
            try
            {
                exames.Clear();
                //Fill in the examnames
                foreach (var exam in Jsubject)
                {
                    Exam ex = new Exam();
                    ex.examname = exam.Key;

                    //Fill in values
                    foreach (var examvalue in (JObject)exam.Value)
                    {
                        if (examvalue.Key == mainWindow.JgradeString)
                            ex.grade = Convert.ToDouble((string)examvalue.Value);
                        else if (examvalue.Key == mainWindow.JpercentageString)
                            ex.percentage = Convert.ToInt32((string)examvalue.Value);
                    }
                    exames.Add(ex);
                }
                return true;
            }
            catch
            {
                MessageBox.Show($"Failed to load config\r\nError: config file at " +
                    $"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\config.json"}" +
                    $" is corrupt", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public void displayExames(ListView listView)
        {
            listView.Items.Clear();
            foreach (Exam exam in exames)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = exam.examname;
                lvi.SubItems.Add(exam.grade.ToString());
                lvi.SubItems.Add(exam.percentage.ToString());
                listView.Items.Add(lvi);
            }
        }
    }
}
