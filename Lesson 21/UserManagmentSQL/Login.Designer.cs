namespace UserManagmentSQL
{
    partial class Login
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
            lblLogIn = new Label();
            lblUserName = new Label();
            textBoxUserName = new TextBox();
            Password = new Label();
            btnLogIn = new Button();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogIn.Location = new Point(197, 10);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(76, 33);
            lblLogIn.TabIndex = 12;
            lblLogIn.Text = "Log In";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(98, 139);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 15);
            lblUserName.TabIndex = 15;
            lblUserName.Text = "User Name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(176, 136);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(210, 23);
            textBoxUserName.TabIndex = 16;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = Color.Black;
            Password.Location = new Point(98, 190);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 17;
            Password.Text = "Password";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(176, 253);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(126, 23);
            btnLogIn.TabIndex = 23;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(176, 187);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 23);
            textBoxPassword.TabIndex = 22;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(Password);
            Controls.Add(textBoxUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblLogIn);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogIn;
        private Label lblUserName;
        private TextBox textBoxUserName;
        private Label Password;
        private Button btnLogIn;
        private TextBox textBoxPassword;
    }
}