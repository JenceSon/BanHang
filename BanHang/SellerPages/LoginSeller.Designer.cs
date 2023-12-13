namespace BanHang.SellerPages
{
    partial class LoginSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSeller));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CloseButton = new Button();
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordLabel = new Label();
            email = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(EmailTextBox);
            panel1.Controls.Add(PasswordLabel);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 426);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_shopee;
            pictureBox1.Location = new Point(250, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Snow;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            CloseButton.ForeColor = Color.OrangeRed;
            CloseButton.Location = new Point(156, 347);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(144, 44);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "Exit";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Snow;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            LoginButton.ForeColor = Color.OrangeRed;
            LoginButton.Location = new Point(156, 285);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 44);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 13.8F);
            PasswordTextBox.ForeColor = Color.LightGray;
            PasswordTextBox.Location = new Point(32, 214);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(392, 38);
            PasswordTextBox.TabIndex = 11;
            PasswordTextBox.Text = "Enter your password";
            PasswordTextBox.Enter += PwdTextBox_Enter;
            PasswordTextBox.Leave += PwdTextBox_Leave;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 13.8F);
            EmailTextBox.ForeColor = Color.LightGray;
            EmailTextBox.Location = new Point(32, 124);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(392, 38);
            EmailTextBox.TabIndex = 10;
            EmailTextBox.Text = "Enter your email or username";
            EmailTextBox.Enter += EmailTextBox_Enter;
            EmailTextBox.Leave += EmailTextBox_Leave;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(32, 180);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(122, 31);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Password:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            email.ForeColor = Color.White;
            email.Location = new Point(32, 90);
            email.Name = "email";
            email.Size = new Size(224, 31);
            email.TabIndex = 8;
            email.Text = "Email or Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 7;
            label1.Text = "Seller Centre";
            // 
            // LoginSeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 426);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginSeller";
            Text = "LoginSeller";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LoginButton;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Label PasswordLabel;
        private Label email;
        private Label label1;
        private Button CloseButton;
        private PictureBox pictureBox1;
    }
}