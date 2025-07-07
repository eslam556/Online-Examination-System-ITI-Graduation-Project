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
using CefSharp.WinForms;
using static System.Net.WebRequestMethods;
namespace Online_Examination_System
{
    public partial class Leaderboard : Form
    {
        string name = "";
        string department = "";
        string id = "";
        public Leaderboard(string Name2, string department, string studentid)
        {
            InitializeComponent();
            NameLabel.Text = Name2;
            name = Name2;
            this.department = department;
            id = studentid;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(name, department, id);
            studentDashboard.Show();
            this.Hide();
        }
        private void display_Click(object sender, EventArgs e)
        {
            string reportUrl = "https://app.powerbi.com/groups/d8bcbfe3-a468-4769-acaa-2605c81eccc6/reports/b00ffb37-5948-4a45-b31d-28fe66dd5fab/dbb620c054c106840725?experience=power-bi";

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
