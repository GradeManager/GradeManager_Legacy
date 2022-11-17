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

namespace gradecalculator
{
    public partial class mainWindow : Form
    {
        
        public static JObject file { get; set; }
        public static JObject Jsubjects { get; set; }
        public static List<Subject> subjectButtons { get; set; } = new List<Subject>();
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            gradeHeader.Width = 100;
            percentHeader.Width = 100;
            nameHeader.Width = gradeList.Width - percentHeader.Width - gradeHeader.Width;

            if (!loadJsonConfig())
                Application.Exit();
        }

        private bool loadJsonConfig()
        {
            if (!File.Exists(GetDirectoryFromExecutable() + "\\config.json"))
            {
                MessageBox.Show("cannot find config.json file\r\n\r\nApplication is terminated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            using (StreamReader sr = new StreamReader(GetDirectoryFromExecutable() + "\\config.json"))
            {
                //Init JSON variables
                string json = sr.ReadToEnd();
                file = JObject.Parse(json);
                Jsubjects = (JObject)file["subjects"];

                //first init the subjects
                foreach (var item in Jsubjects)
                {
                    createSubButton(item.Key, subjectButtons.Count);
                }
            }
            return true;
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
                
            };

            subjectButtons.Add(subject);
            subjectBx.Controls.Add(subject);
        }

        private void removeSubButton(string Subject)
        {
            foreach (Subject subject in subjectButtons)
            {
                if (subject.Text == Subject)
                {
                    subjectButtons.Remove(subject);
                    subjectBx.Controls.Remove(subject);
                }
            }
        }

        private string GetDirectoryFromExecutable()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
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

        public Subject(string subject)
        {
            exames = new List<Exam>();

            Exam exam = new Exam();

            foreach (var item in (JObject)mainWindow.Jsubjects[subject])
            {
                foreach(var item2 in (JObject)item.Value)
                {
                    MessageBox.Show(item2.Key);
                }
            }


        }
    }
}
