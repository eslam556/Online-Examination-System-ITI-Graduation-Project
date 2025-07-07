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
    public partial class Settings : Form
    {
        string name = "";
        string department = "";
        string StudentID = "";
        public Settings(string Name2, string Department, string studentID)
        {
            InitializeComponent();
            NameLabel.Text = Name2;
            name = Name2;
            department = Department;
            StudentID = studentID;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutTheSystem aboutTheSystem = new AboutTheSystem(name,department, StudentID);
            aboutTheSystem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs(name,department, StudentID);
            contactUs.Show();
            this.Hide();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(name,department,StudentID);
            changePassword.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(name, department, StudentID);
            studentDashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();    
        }
    }
}
