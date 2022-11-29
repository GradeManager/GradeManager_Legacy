using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeManager
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
        private static string configFilePath { get; set; } = GetDirectoryFromExecutable() + "\\config.json";

        public const string JgradeString = "grade";
        public const string JpercentageString = "percentage";
        public const string JdateString = "date";

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
            this.KeyPreview = true;
            gradeHeader.Width = 80;
            percentHeader.Width = 80;
            dateHeader.Width = 120;
            nameHeader.Width = gradeList.Width - percentHeader.Width - gradeHeader.Width - dateHeader.Width;
            if (!deserializeJsonConfig(configFilePath))
                Application.Exit();
            loadConfig();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig(configFilePath);
            else
            {
                var msgBtns = MessageBox.Show("Safe changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msgBtns == DialogResult.Yes)
                    serializeJsonConfig(configFilePath);
            }
        }

        private void loadConfig()
        {
            subjectBx.Controls.Clear();
            subjectButtons.Clear();
            //Wrap the subjects
            foreach (var item in Jsubjects)
            {
                createSubButton(item.Key, subjectButtons.Count);
            }
            //Refresh Lbls
            updateLbl();
        }

        private void updateLbl()
        {
            if (selectedSubject != null)
                averageCurLbl.Text = MSKMath.getArithmeticMean(selectedSubject.exames).ToString();

            averageAllLbl.Text = MSKMath.getAverageOfAllSubjects(subjectButtons).ToString();

            plusPointLbl.Text = MSKMath.getPlusPoints(subjectButtons).ToString();
        }

        private bool deserializeJsonConfig(string configFile)
        {
            if (!File.Exists(configFile))
            {
                MessageBox.Show("cannot find config.json file\r\n\r\nApplication is terminated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Deserialize JSON file
            using (StreamReader sr = new StreamReader(configFile))
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

        private bool serializeJsonConfig(string configFile)
        {
            if (!File.Exists(configFile))
            {
                MessageBox.Show("cannot find config.json file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                File.WriteAllText(configFile, JsonConvert.SerializeObject(file));
            }
            catch (Exception ex)
            {
                MessageBox.Show("cannot write to config.json file \r\n\r\nError:\r\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private static string GetDirectoryFromExecutable()
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
                updateLbl();
            };

            subjectButtons.Add(subject);
            subjectBx.Controls.Add(subject);
        }

        private void addSubject()
        {
            Design.changeItemVisibility(this, false);
            aS.ShowDialog();
            Design.changeItemVisibility(this, true);

            loadConfig();

            if ((bool)Jautosafemode.Value)
                serializeJsonConfig(configFilePath);
        }
        private void removeSubject()
        {
            Design.changeItemVisibility(this, false);
            rS.ShowDialog();
            Design.changeItemVisibility(this, true);

            loadConfig();

            if ((bool)Jautosafemode.Value)
                serializeJsonConfig(configFilePath);
        }
        private void addGrade()
        {
            Design.changeItemVisibility(this, false);
            aG.ShowDialog();
            Design.changeItemVisibility(this, true);

            loadConfig();

            //Rewrap Body of selectedSubject
            if (selectedSubject != null)
                selectedSubject.displayExames(gradeList);
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig(configFilePath);
        }
        private void removeGrade()
        {
            foreach (ListViewItem item in gradeList.SelectedItems)
            {
                selectedSubject.Jsubject.Property(item.Text).Remove();
            }
            loadConfig();

            selectedSubject.getExamesFromConfig();
            selectedSubject.displayExames(gradeList);
            
            if ((bool)Jautosafemode.Value)
                serializeJsonConfig(configFilePath);
        }

        private void exportCSV()
        {
            Stream stream;
            StreamWriter sw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = saveFileDialog.OpenFile()) != null)
                    {
                        sw = new StreamWriter(stream);
                        sw.WriteLine("Subject; Exam; Grade; Percentage; Date");

                        foreach (Subject subj in subjectButtons)
                        {
                            foreach (Subject.Exam ex in subj.exames)
                            {
                                sw.WriteLine($"{subj.Text}; {ex.examname}; {ex.grade}; {ex.percentage}; {ex.date}");
                            }
                        }
                        sw.Dispose();
                        stream.Dispose();
                        sw.Close();
                        stream.Close();
                    }
                } catch
                {
                    MessageBox.Show("Failed to create CSV\r\n\r\nError: File is in use by another process", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exportConf()
        {
            Stream stream;

            if (saveFileDialogJson.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = saveFileDialog.OpenFile()) != null)
                    {
                        stream.Dispose();
                        stream.Close();
                    }
                    serializeJsonConfig(Path.GetFullPath(saveFileDialogJson.FileName));
                }
                catch
                {
                    MessageBox.Show("Failed to create config\r\n\r\nError: File is in use by another process", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void importConf()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != null)
                {
                    if (deserializeJsonConfig(Path.GetFullPath(openFileDialog.FileName)))
                        serializeJsonConfig(configFilePath);
                    else Application.Exit();
                    loadConfig();
                }
            }
        }

        private void previewConf()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != null)
                {
                    if (deserializeJsonConfig(Path.GetFullPath(openFileDialog.FileName)))
                        configFilePath = Path.GetFullPath(openFileDialog.FileName);
                    else Application.Exit();
                    loadConfig();
                }
            }
        }

        //#######--------------------------------------------|
        //Controls--------------------------------------------|
        //#######--------------------------------------------|

        private void exportConfBtn_Click(object sender, EventArgs e)
        {
            exportConf();
            this.ActiveControl = null;
        }

        private void exportCSVBtn_Click(object sender, EventArgs e)
        {
            exportCSV();
            this.ActiveControl = null;
        }

        private void importConfBtn_Click(object sender, EventArgs e)
        {
            importConf();
            this.ActiveControl = null;
        }

        private void previewConfBtn_Click(object sender, EventArgs e)
        {
            previewConf();
            this.ActiveControl = null;
        }
        private void autoSafeModeBtn_Click(object sender, EventArgs e)
        {
            toggleAutoSafeMode();
            this.ActiveControl = null;
        }

        private void mW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                serializeJsonConfig(configFilePath);
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
            serializeJsonConfig(configFilePath);
        }
        private void CM_AddBtn_Click(object sender, EventArgs e)
        {
            addSubject();
        }

        private void CM_AddGrade_Click(object sender, System.EventArgs e)
        {
            addGrade();
        }

        private void CM_RemoveBtn_Click(object sender, EventArgs e)
        {
            removeSubject();
        }

        private void CM_RemoveGrade_Click(object sender, System.EventArgs e)
        {
            removeGrade();
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

            public DateTime date { get; set; }
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
                        else if (examvalue.Key == mainWindow.JdateString)
                            ex.date = (DateTime)examvalue.Value;
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
                lvi.SubItems.Add(exam.date.ToString("dd/MM/yyyy"));
                listView.Items.Add(lvi);
            }
        }
    }
}
