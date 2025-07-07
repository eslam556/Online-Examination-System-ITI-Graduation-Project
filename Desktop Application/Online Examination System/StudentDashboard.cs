using Microsoft.EntityFrameworkCore.Metadata;
using System;
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
    public partial class StudentDashboard : Form
    {
        string Name2 = "";
        string Department = "";
        string StudentID = "";
        public StudentDashboard(string fullName, string department, string StudentID)
        {
            InitializeComponent();
            NameLabel.Text = fullName;
            Name2 = fullName;
            DepartmentLabel.Text = department;
            Department = department;
            this.StudentID = StudentID;
        }

        private void pictureBox1_Click(object sender, EventArgs e) => Application.Exit();
        private void button2_MouseClick_2(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(Name2, Department, StudentID);
            settings.Show();
            this.Hide();
        }

        private void EnterExam_Click(object sender, EventArgs e)
        {
            EnterExam enterExam = new EnterExam(Name2, Department, StudentID);
            enterExam.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard(Name2,Department,StudentID);
            leaderboard.Show();
            this.Hide();

        }
    }
}
