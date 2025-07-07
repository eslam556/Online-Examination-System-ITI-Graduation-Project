using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Examination_System
{
    public partial class InstructorDashboard : Form
    {
        string Name2 = "";
        string InstructorID = "";

        public InstructorDashboard(string fullname, string InstructorID)
        {
            InitializeComponent();
            Name2 = fullname;
            this.InstructorID = InstructorID;
            NameLabel.Text = fullname;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            InstructorSettings instructorSettings = new InstructorSettings(Name2, InstructorID);
            instructorSettings.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewReports viewReports = new ViewReports(Name2, InstructorID);
            viewReports.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewStudentAnswers viewStudentAnswers = new ViewStudentAnswers(Name2, InstructorID);
            viewStudentAnswers.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewCourses viewCourses = new ViewCourses(Name2, InstructorID);
            viewCourses.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateExam generateExam = new GenerateExam(Name2, InstructorID);
            generateExam.Show();
            this.Hide();
        }
    }
}
