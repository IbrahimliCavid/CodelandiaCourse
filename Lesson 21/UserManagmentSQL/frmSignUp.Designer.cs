namespace UserManagmentSQL
{
    partial class frmSignUp
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
            label1 = new Label();
            lblName = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            lblUserName = new Label();
            textBoxPassword = new TextBox();
            Password = new Label();
            textBoxEmail = new TextBox();
            lblEmail = new Label();
            textBoxRepassword = new TextBox();
            lblRepassword = new Label();
            btnSignUp = new Button();
            linkLabelLogIn = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 23);
            label1.Name = "label1";
            label1.Size = new Size(92, 33);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(69, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(145, 109);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(145, 149);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(210, 23);
            textBoxSurname.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(67, 152);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(145, 230);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = Color.Black;
            Password.Location = new Point(67, 230);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(145, 194);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(67, 194);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // textBoxRepassword
            // 
            textBoxRepassword.Location = new Point(145, 270);
            textBoxRepassword.Name = "textBoxRepassword";
            textBoxRepassword.Size = new Size(210, 23);
            textBoxRepassword.TabIndex = 10;
            // 
            // lblRepassword
            // 
            lblRepassword.AutoSize = true;
            lblRepassword.ForeColor = Color.Black;
            lblRepassword.Location = new Point(67, 270);
            lblRepassword.Name = "lblRepassword";
            lblRepassword.Size = new Size(70, 15);
            lblRepassword.TabIndex = 9;
            lblRepassword.Text = "Repassword";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(145, 341);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(126, 23);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // linkLabelLogIn
            // 
            linkLabelLogIn.AutoSize = true;
            linkLabelLogIn.Location = new Point(305, 349);
            linkLabelLogIn.Name = "linkLabelLogIn";
            linkLabelLogIn.Size = new Size(40, 15);
            linkLabelLogIn.TabIndex = 12;
            linkLabelLogIn.TabStop = true;
            linkLabelLogIn.Text = "Log In";
            linkLabelLogIn.LinkClicked += linkLabelLogIn_LinkClicked;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(linkLabelLogIn);
            Controls.Add(btnSignUp);
            Controls.Add(textBoxRepassword);
            Controls.Add(lblRepassword);
            Controls.Add(textBoxEmail);
            Controls.Add(lblEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(Password);
            Controls.Add(textBoxSurname);
            Controls.Add(lblUserName);
            Controls.Add(textBoxName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "frmSignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label lblUserName;
        private TextBox textBoxPassword;
        private Label Password;
        private TextBox textBoxEmail;
        private Label lblEmail;
        private TextBox textBoxRepassword;
        private Label lblRepassword;
        private Button btnSignUp;
        private LinkLabel linkLabelLogIn;
    }
}