namespace Online_Examination_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UserComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            UserTextbox = new TextBox();
            PasswordTextBox = new TextBox();
            BtnLogin = new Button();
            ShowPassword = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UserComboBox
            // 
            UserComboBox.FormattingEnabled = true;
            UserComboBox.Items.AddRange(new object[] { "Instructor", "Student" });
            UserComboBox.Location = new Point(510, 267);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(312, 23);
            UserComboBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cancel_10336224;
            pictureBox1.Location = new Point(1321, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // UserTextbox
            // 
            UserTextbox.Location = new Point(510, 396);
            UserTextbox.Name = "UserTextbox";
            UserTextbox.Size = new Size(312, 23);
            UserTextbox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(510, 508);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(312, 23);
            PasswordTextBox.TabIndex = 6;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = SystemColors.MenuHighlight;
            BtnLogin.Location = new Point(587, 592);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(123, 37);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += LoginButton_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.BackColor = Color.Transparent;
            ShowPassword.ForeColor = SystemColors.Highlight;
            ShowPassword.Location = new Point(602, 552);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(108, 19);
            ShowPassword.TabIndex = 8;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = false;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1221, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1366, 768);
            Controls.Add(pictureBox2);
            Controls.Add(ShowPassword);
            Controls.Add(BtnLogin);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(UserComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox UserComboBox;
        private PictureBox pictureBox1;
        private TextBox UserTextbox;
        private TextBox PasswordTextBox;
        private Button BtnLogin;
        private CheckBox ShowPassword;
        private PictureBox pictureBox2;
    }
}
