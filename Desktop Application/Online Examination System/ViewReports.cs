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
    public partial class ViewReports : Form
    {
        string Name2 = "";
        string InstructorID = "";
        public ViewReports(string name2, string instructorID)
        {
            InitializeComponent();
            Name2 = name2;
            InstructorID = instructorID;
            comboBox1.Items.Add("Top Performing Students");
            comboBox1.Items.Add("Student Social Network");
            comboBox1.Items.Add("Student Graduation Analysis");
            comboBox1.Items.Add("Instrutctor Performance Analysis");
            comboBox1.Items.Add("Instructor Workload Analysis");
            comboBox1.Items.Add("At Risk Student Analysis");
            comboBox1.Items.Add("Students Certification Analysis");
            comboBox1.Items.Add("Students Demographics Analysis");
            comboBox1.Items.Add("Students Freelancing Jobs Analysis");
            comboBox1.Items.Add("Students Grades Analysis");
            comboBox1.Items.Add("Students Hiring Analysis");
            comboBox1.Items.Add("Students Retakes Analysis");
            comboBox1.Items.Add("Department Performance Analysis");
            comboBox1.Items.Add("Department Popularity Analysis");
            comboBox1.Items.Add("Branch Popularity Analysis");
            comboBox1.Items.Add("Branch Performance Analysis");
            comboBox1.Items.Add("Course Progress Analysis");
            comboBox1.Items.Add("Topic Coverage Analysis");
            comboBox1.Items.Add("Exam Progress Analysis");
            comboBox1.Items.Add("Question Analysis Analysis");
            comboBox1.Items.Add("Get Course Topics");
            comboBox1.Items.Add("Get Student Grades");
            comboBox1.Items.Add("Students According to Departments");

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
            InstructorDashboard instructorDashboard = new InstructorDashboard(Name2, InstructorID);
            instructorDashboard.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
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
            else if (comboBox1.SelectedIndex == 1)
            {
                string reportUrl = "https://app.powerbi.com/groups/d8bcbfe3-a468-4769-acaa-2605c81eccc6/reports/4318f884-baa6-4f1c-9944-b329de500297/05d737b1deac19ac803d?experience=power-bi";

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
            else if (comboBox1.SelectedIndex == 2)
            {
                string reportUrl = "https://app.powerbi.com/groups/d8bcbfe3-a468-4769-acaa-2605c81eccc6/reports/b66c3d5f-8d75-4356-9fa3-bd889ae1d20c/1d1b63a85e65000de021?experience=power-bi";

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
            else if (comboBox1.SelectedIndex == 3)
            {
                string reportUrl = "https://app.powerbi.com/links/uiG87Tn2MO?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 4)
            {
                string reportUrl = "https://app.powerbi.com/links/6Bf-rQvlwA?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 5)
            {
                string reportUrl = "https://app.powerbi.com/links/6Bf-rQvlwA?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 6)
            {
                string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=f8a7ecb4-24f5-40d4-8fef-0c73b6eed983&autoAuth=true&ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8";

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
            else if (comboBox1.SelectedIndex == 7)
            {
                string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=374bd18e-a158-4bd7-aae5-ca38ec028178&autoAuth=true&ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8";

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
            else if (comboBox1.SelectedIndex == 8)
            {
                string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=bd4b0a30-b759-4fdd-9bfb-5a1320d5d913&autoAuth=true&ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8";

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
            else if (comboBox1.SelectedIndex == 9)
            {
                string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=bad2bbce-41f8-41be-a4a9-2355b062efb5&autoAuth=true&ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8";

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
            else if (comboBox1.SelectedIndex == 10)
            {
                string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=d5a0b489-97d6-4c00-8233-28c1dd6854e4&autoAuth=true&ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8";

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
            else if (comboBox1.SelectedIndex == 11)
            {
                string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=4b8987fe-b256-4197-ad03-96cdf9d8e40b&autoAuth=true&ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8";

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
            else if (comboBox1.SelectedIndex == 12)
            {
                string reportUrl = "https://app.powerbi.com/links/qdtbjreiqX?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 13)
            {
                string reportUrl = "https://app.powerbi.com/links/qdtbjreiqX?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 14)
            {
                string reportUrl = "https://app.powerbi.com/links/ABHZHXar9E?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 15)
            {
                string reportUrl = "https://app.powerbi.com/links/zrFBofRhnu?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 16)
            {
                string reportUrl = "https://app.powerbi.com/links/nmiToR0Vvh?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 17)
            {
                string reportUrl = "https://app.powerbi.com/links/jNDQhUdaJK?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 18)
            {
                string reportUrl = "https://app.powerbi.com/links/4LLp0A75Qy?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 19)
            {
                string reportUrl = "https://app.powerbi.com/links/D69Y1xkkvL?ctid=6845d6ca-1ec5-4c0e-9e9d-34130ce0a0b8&pbi_source=linkShare";

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
            else if (comboBox1.SelectedIndex == 20)
            {
                string reportUrl = "https://app.powerbi.com/groups/2b422574-661b-44fb-bf01-7f5d4eab0816/rdlreports/d92f8056-5867-4406-a3b5-0d014a45ca5d?experience=power-bi";

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
            else if (comboBox1.SelectedIndex == 21)
            {
                string reportUrl = "https://app.powerbi.com/groups/2b422574-661b-44fb-bf01-7f5d4eab0816/rdlreports/5206a874-ed28-403b-b62f-433de0917434?experience=power-bi";

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
            else if (comboBox1.SelectedIndex == 22)
            {
                string reportUrl = "https://app.powerbi.com/groups/2b422574-661b-44fb-bf01-7f5d4eab0816/rdlreports/387db3d1-9184-441c-a9ec-3631d82c65dc?experience=power-bi";

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
}
