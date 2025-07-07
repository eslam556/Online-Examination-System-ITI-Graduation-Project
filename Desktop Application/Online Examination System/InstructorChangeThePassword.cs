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
    public partial class InstructorChangeThePassword : Form
    {
        string name = "";
        string id = "";
        public InstructorChangeThePassword(string name, string id)
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
            InstructorSettings instructorSettings = new InstructorSettings(name, id);
            instructorSettings.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InstructorIDText = StudentTextBox.Text;
            int InstructorID = int.Parse(InstructorIDText);
            int InstructorIDInteger = int.Parse(id);
            string NewPassword = NewPasswordTextBox.Text;
            if (InstructorID == 0 || InstructorID == null || string.IsNullOrWhiteSpace(NewPassword))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (InstructorID != InstructorIDInteger)
            {
                MessageBox.Show("Please Enter Your Instructor ID Correctly");
            }
            else
            {
                string connectionString = "Data Source=.;Initial Catalog=Examination System;Integrated Security=True;TrustServerCertificate=True;";
                string query = "SELECT Password FROM Instructor WHERE Instructor_ID = @InstructorID";
                string updateQuery = "UPDATE Instructor SET Password = @NewPassword WHERE Instructor_ID = @InstructorID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", NewPassword);
                        updateCmd.Parameters.AddWithValue("@InstructorID", InstructorID);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Password changed successfully.");
                    }
                }
            }
        }
    }
}
