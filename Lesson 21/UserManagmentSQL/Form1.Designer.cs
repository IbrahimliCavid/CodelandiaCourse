namespace UserManagmentSQL
{
    partial class frmSignUp
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
            panel1 = new Panel();
            btnSignUp = new Button();
            label7 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxRepassword = new TextBox();
            textBoxPassword = new TextBox();
            label4 = new Label();
            textBoxUsername = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxRepassword);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(62, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 452);
            panel1.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(118, 363);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(85, 26);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 170);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 15;
            label7.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(63, 188);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 23);
            textBoxEmail.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 289);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "RePassword";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 231);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 13;
            label6.Text = "Password";
            // 
            // textBoxRepassword
            // 
            textBoxRepassword.Location = new Point(63, 307);
            textBoxRepassword.Name = "textBoxRepassword";
            textBoxRepassword.Size = new Size(217, 23);
            textBoxRepassword.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(63, 249);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(217, 23);
            textBoxPassword.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 170);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(63, 130);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(217, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 112);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "User name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(64, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(217, 23);
            textBoxName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 58);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 33);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "frmSignUp";
            Text = "Sign Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnSignUp;
        private Label label7;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label6;
        private TextBox textBoxRepassword;
        private TextBox textBoxPassword;
        private Label label4;
        private TextBox textBoxUsername;
        private Label label3;
        private TextBox textBoxName;
    }
}
