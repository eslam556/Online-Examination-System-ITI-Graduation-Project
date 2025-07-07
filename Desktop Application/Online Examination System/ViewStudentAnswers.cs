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
    public partial class ViewStudentAnswers : Form
    {
        string name = "";
        string id = "";
        public ViewStudentAnswers(string name, string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
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
            InstructorDashboard instructorDashboard = new InstructorDashboard(name, id);
            instructorDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reportUrl = "https://app.powerbi.com/groups/2b422574-661b-44fb-bf01-7f5d4eab0816/rdlreports/b9b65c94-ad2a-4120-b1e3-eeec769c3fac?experience=power-bi";

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
