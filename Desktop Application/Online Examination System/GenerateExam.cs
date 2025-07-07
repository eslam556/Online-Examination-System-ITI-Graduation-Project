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
    public partial class GenerateExam : Form
    {
        string name2 = "";
        string id = "";
        public GenerateExam(string name2, string id)
        {
            InitializeComponent();
            this.name2 = name2;
            this.id = id;
            NameLabel.Text = name2;
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
            InstructorDashboard instructorDashboard = new InstructorDashboard(name2, id);
            instructorDashboard.Show();
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
