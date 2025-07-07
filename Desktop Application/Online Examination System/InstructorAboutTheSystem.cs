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
    public partial class InstructorAboutTheSystem : Form
    {
        string name = "";
        string InstructorID = "";
        public InstructorAboutTheSystem(string name,string InstructorID)
        {
            InitializeComponent();
            this.name = name;
            NameLabel.Text = name;
            this.InstructorID = InstructorID;
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
            InstructorSettings instructorSettings = new InstructorSettings(name, InstructorID);
            instructorSettings.Show();
            this.Hide();
        }
    }
}
