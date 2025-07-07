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
    public partial class AboutTheSystem : Form
    {
        string name2 = "";
        string department = "";
        string StudentID = "";
        public AboutTheSystem(string name, string Department, string studentID)
        {
            InitializeComponent();
            NameLabel.Text = name;
            name2 = name;
            department = Department;
            StudentID = studentID;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(name2, department, StudentID);
            settings.Show();
            this.Hide();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
