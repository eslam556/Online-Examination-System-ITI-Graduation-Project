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
    public partial class InstructorSettings : Form
    {
        string Name = "";
        string InstructorID = "";
        public InstructorSettings(string name, string instructorID)
        {
            InitializeComponent();
            Name = name;
            InstructorID = instructorID;
            NameLabel.Text = name;
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
            InstructorDashboard instructorDashboard = new InstructorDashboard(Name, InstructorID);
            instructorDashboard.Show();
            this.Hide();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstructorAboutTheSystem instructorAboutTheSystem = new InstructorAboutTheSystem(Name, InstructorID);
            instructorAboutTheSystem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstructorContactUs instructorContactus = new InstructorContactUs(Name, InstructorID);
            instructorContactus.Show();
            this.Hide();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            InstructorChangeThePassword instructorChangeThePassword=new InstructorChangeThePassword(Name, InstructorID);
            instructorChangeThePassword.Show();
            this.Hide();
        }
    }
}
