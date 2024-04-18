namespace WindowsFormsUser
{
    partial class AdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AdminAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameByAdmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailByAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passByAdmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rePassByAdmin = new System.Windows.Forms.TextBox();
            this.nameByAdmin = new System.Windows.Forms.TextBox();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.getUser = new System.Windows.Forms.Button();
            this.DeleteInputBtn = new System.Windows.Forms.Button();
            this.searchUserInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.removeAllUserBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // AdminAddBtn
            // 
            this.AdminAddBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddBtn.Location = new System.Drawing.Point(48, 313);
            this.AdminAddBtn.Name = "AdminAddBtn";
            this.AdminAddBtn.Size = new System.Drawing.Size(94, 28);
            this.AdminAddBtn.TabIndex = 25;
            this.AdminAddBtn.Text = "Add User";
            this.AdminAddBtn.UseVisualStyleBackColor = true;
            this.AdminAddBtn.Click += new System.EventHandler(this.AdminAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username";
            // 
            // userNameByAdmin
            // 
            this.userNameByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameByAdmin.Location = new System.Drawing.Point(48, 113);
            this.userNameByAdmin.Name = "userNameByAdmin";
            this.userNameByAdmin.Size = new System.Drawing.Size(200, 22);
            this.userNameByAdmin.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // emailByAdmin
            // 
            this.emailByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailByAdmin.Location = new System.Drawing.Point(48, 166);
            this.emailByAdmin.Name = "emailByAdmin";
            this.emailByAdmin.Size = new System.Drawing.Size(200, 22);
            this.emailByAdmin.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password";
            // 
            // passByAdmin
            // 
            this.passByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passByAdmin.Location = new System.Drawing.Point(48, 219);
            this.passByAdmin.Name = "passByAdmin";
            this.passByAdmin.PasswordChar = '*';
            this.passByAdmin.Size = new System.Drawing.Size(200, 22);
            this.passByAdmin.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Repassword";
            // 
            // rePassByAdmin
            // 
            this.rePassByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassByAdmin.Location = new System.Drawing.Point(48, 269);
            this.rePassByAdmin.Name = "rePassByAdmin";
            this.rePassByAdmin.PasswordChar = '*';
            this.rePassByAdmin.Size = new System.Drawing.Size(200, 22);
            this.rePassByAdmin.TabIndex = 23;
            // 
            // nameByAdmin
            // 
            this.nameByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameByAdmin.Location = new System.Drawing.Point(48, 62);
            this.nameByAdmin.Name = "nameByAdmin";
            this.nameByAdmin.Size = new System.Drawing.Size(200, 22);
            this.nameByAdmin.TabIndex = 15;
            // 
            // userTable
            // 
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Username,
            this.Email,
            this.Password});
            this.userTable.Location = new System.Drawing.Point(1, 427);
            this.userTable.Name = "userTable";
            this.userTable.Size = new System.Drawing.Size(600, 170);
            this.userTable.TabIndex = 26;
            this.userTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveRow);
            // 
            // ID
            // 
            this.ID.HeaderText = "Idenficator";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.LinkColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(573, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(15, 16);
            this.Exit.TabIndex = 27;
            this.Exit.TabStop = true;
            this.Exit.Text = "X";
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(148, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 28);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // getUser
            // 
            this.getUser.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getUser.Location = new System.Drawing.Point(358, 104);
            this.getUser.Name = "getUser";
            this.getUser.Size = new System.Drawing.Size(83, 28);
            this.getUser.TabIndex = 39;
            this.getUser.Text = "Search";
            this.getUser.UseVisualStyleBackColor = true;
            this.getUser.Click += new System.EventHandler(this.getUser_Click);
            // 
            // DeleteInputBtn
            // 
            this.DeleteInputBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInputBtn.Location = new System.Drawing.Point(470, 104);
            this.DeleteInputBtn.Name = "DeleteInputBtn";
            this.DeleteInputBtn.Size = new System.Drawing.Size(88, 28);
            this.DeleteInputBtn.TabIndex = 40;
            this.DeleteInputBtn.Text = "Delete";
            this.DeleteInputBtn.UseVisualStyleBackColor = true;
            this.DeleteInputBtn.Click += new System.EventHandler(this.DeleteInputBtn_Click);
            // 
            // searchUserInput
            // 
            this.searchUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserInput.Location = new System.Drawing.Point(358, 60);
            this.searchUserInput.Name = "searchUserInput";
            this.searchUserInput.Size = new System.Drawing.Size(200, 22);
            this.searchUserInput.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "-------------------------------------------------";
            // 
            // removeAllUserBtn
            // 
            this.removeAllUserBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllUserBtn.Location = new System.Drawing.Point(378, 242);
            this.removeAllUserBtn.Name = "removeAllUserBtn";
            this.removeAllUserBtn.Size = new System.Drawing.Size(149, 28);
            this.removeAllUserBtn.TabIndex = 44;
            this.removeAllUserBtn.Text = "Remove All User";
            this.removeAllUserBtn.UseVisualStyleBackColor = true;
            this.removeAllUserBtn.Click += new System.EventHandler(this.removeAllUserBtn_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(13, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(22, 13);
            this.back.TabIndex = 45;
            this.back.TabStop = true;
            this.back.Text = "<---";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.back);
            this.Controls.Add(this.removeAllUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchUserInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteInputBtn);
            this.Controls.Add(this.getUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.AdminAddBtn);
            this.Controls.Add(this.rePassByAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passByAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailByAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameByAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameByAdmin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminAddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameByAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailByAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passByAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rePassByAdmin;
        private System.Windows.Forms.TextBox nameByAdmin;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.LinkLabel Exit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button getUser;
        private System.Windows.Forms.Button DeleteInputBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.TextBox searchUserInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeAllUserBtn;
        private System.Windows.Forms.LinkLabel back;
    }
}