using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Examination_System
{
    public partial class EnterExam : Form
    {
        string name = "";
        string department = "";
        string studentId = "";
        public EnterExam(string name, string department, string studentId)
        {
            InitializeComponent();
            this.name = name;
            this.department = department;
            this.studentId = studentId;
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
            StudentDashboard studentDashboard = new StudentDashboard(name, department, studentId);
            studentDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reportUrl = "https://app.powerbi.com/groups/2b422574-661b-44fb-bf01-7f5d4eab0816/rdlreports/09a09196-4231-41e9-a760-e4e18c4b5a11?experience=power-bi";

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = reportUrl,
                    UseShellExecute = true // This is required in .NET Core / .NET 5+
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open browser: " + ex.Message);
            }
        }
    }
}
