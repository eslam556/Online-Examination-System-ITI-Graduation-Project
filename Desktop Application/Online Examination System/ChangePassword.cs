using Microsoft.Data.SqlClient;
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
    public partial class ChangePassword : Form
    {
        string name4 = "";
        string department = "";
        string StudentID = "";
        public ChangePassword(string name3, string department, string studentID)
        {
            InitializeComponent();
            NameLabel.Text = name3;
            name4 = name3;
            this.department = department;
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
            Settings settings = new Settings(name4,department, StudentID);
            settings.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentIdText = StudentTextBox.Text;
            int studentID = int.Parse(studentIdText);
            int StudentIDInteger = int.Parse(StudentID);
            string NewPassword = NewPasswordTextBox.Text;
            if (studentID == 0 || studentID == null || string.IsNullOrWhiteSpace(NewPassword))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (studentID != StudentIDInteger)
            {
                MessageBox.Show("Please Enter Your Student ID Correctly");
            }
            else
            {
                string connectionString = "Data Source=.;Initial Catalog=Examination System;Integrated Security=True;TrustServerCertificate=True;";
                string query = "SELECT Password FROM Student WHERE Student_ID = @studentID";
                string updateQuery = "UPDATE Student SET Password = @NewPassword WHERE Student_ID = @studentID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", NewPassword);
                        updateCmd.Parameters.AddWithValue("@studentID", studentID);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Password changed successfully.");
                    }
                }
            }
        }
    }
}
