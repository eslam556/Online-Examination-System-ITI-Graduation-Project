using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace Online_Examination_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                PasswordTextBox.PasswordChar = '\0';
                ShowPassword.Text = "Hide Password";
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                ShowPassword.Text = "Show Password";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = UserTextbox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=Examination System;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "";

                if (UserComboBox.Text == "Instructor")
                {
                    query = @"
                SELECT Instructor_ID, First_Name, Last_Name
                FROM Instructor
                WHERE Email = @Email AND Password = @Password";
                }
                else if (UserComboBox.Text == "Student")
                {
                    query = @"
                SELECT Student_ID, First_Name, Last_Name, Department_Name
                FROM Student
                INNER JOIN Department ON Student.Department_ID = Department.Department_ID
                WHERE Email = @Email AND Password = @Password";
                }
                else
                {
                    MessageBox.Show("Please select a valid user type.");
                    return;
                }

                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["First_Name"].ToString();
                                string lastName = reader["Last_Name"].ToString();
                                string fullName = $"{firstName} {lastName}";

                                if (UserComboBox.Text == "Student")
                                {
                                    string department = reader["Department_Name"].ToString();
                                    string studentID = reader["Student_ID"].ToString();

                                    StudentDashboard dashboard = new StudentDashboard(fullName, department, studentID);
                                    dashboard.Show();
                                }
                                else if (UserComboBox.Text == "Instructor")
                                {
                                    string instructorID = reader["Instructor_ID"].ToString();

                                    InstructorDashboard dashboard = new InstructorDashboard(fullName, instructorID);
                                    dashboard.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string reportUrl = "https://luxury-hotteok-365cbc.netlify.app/";

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
