namespace Online_Examination_System
{
    partial class StudentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            EnterExam = new Button();
            button1 = new Button();
            button2 = new Button();
            SettingsButton = new Button();
            pictureBox1 = new PictureBox();
            NameLabel = new Label();
            DepartmentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EnterExam
            // 
            EnterExam.BackColor = Color.White;
            EnterExam.BackgroundImageLayout = ImageLayout.None;
            EnterExam.FlatAppearance.BorderSize = 0;
            EnterExam.FlatAppearance.MouseDownBackColor = Color.Transparent;
            EnterExam.FlatAppearance.MouseOverBackColor = Color.Transparent;
            EnterExam.Image = Properties.Resources.Enter_Exam;
            EnterExam.Location = new Point(467, 267);
            EnterExam.Name = "EnterExam";
            EnterExam.Size = new Size(166, 36);
            EnterExam.TabIndex = 0;
            EnterExam.UseVisualStyleBackColor = false;
            EnterExam.Click += EnterExam_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(966, 267);
            button1.Name = "button1";
            button1.Size = new Size(166, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(966, 494);
            button2.Name = "button2";
            button2.Size = new Size(166, 36);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += button2_MouseClick_2;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.White;
            SettingsButton.BackgroundImageLayout = ImageLayout.None;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SettingsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
            SettingsButton.Location = new Point(467, 494);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(166, 36);
            SettingsButton.TabIndex = 3;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cancel_10336224;
            pictureBox1.Location = new Point(1321, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.DodgerBlue;
            NameLabel.Location = new Point(238, 139);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(143, 32);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "NameLabel";
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.BackColor = Color.Transparent;
            DepartmentLabel.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentLabel.ForeColor = Color.DodgerBlue;
            DepartmentLabel.Location = new Point(1061, 139);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(213, 32);
            DepartmentLabel.TabIndex = 7;
            DepartmentLabel.Text = "DepartmentLabel";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled__7_;
            ClientSize = new Size(1366, 768);
            Controls.Add(DepartmentLabel);
            Controls.Add(NameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(SettingsButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EnterExam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDashboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterExam;
        private Button button1;
        private Button button2;
        private Button SettingsButton;
        private PictureBox pictureBox1;
        private Label NameLabel;
        private Label DepartmentLabel;
    }
}