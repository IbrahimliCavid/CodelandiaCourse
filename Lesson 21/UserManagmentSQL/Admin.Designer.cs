namespace UserManagmentSQL
{
    partial class Admin
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
            userTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            UserPassword = new DataGridViewTextBoxColumn();
            Deleted = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            textBoxRepassword = new TextBox();
            lblRepassword = new Label();
            textBoxEmail = new TextBox();
            lblEmail = new Label();
            textBoxPassword = new TextBox();
            Password = new Label();
            textBoxSurname = new TextBox();
            lblUserName = new Label();
            textBoxName = new TextBox();
            lblName = new Label();
            btnAdd = new Button();
            textBoxRole = new TextBox();
            roleId = new Label();
            btnSearchUser = new Button();
            textBoxSearch = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // userTable
            // 
            userTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Columns.AddRange(new DataGridViewColumn[] { Id, Name, UserName, Email, UserPassword, Deleted, CreatedDate });
            userTable.Location = new Point(-2, 298);
            userTable.Name = "userTable";
            userTable.Size = new Size(803, 150);
            userTable.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.Name = "UserName";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // UserPassword
            // 
            UserPassword.HeaderText = "Password";
            UserPassword.Name = "UserPassword";
            // 
            // Deleted
            // 
            Deleted.HeaderText = "Deleted";
            Deleted.Name = "Deleted";
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "CreatedDate";
            CreatedDate.Name = "CreatedDate";
            // 
            // textBoxRepassword
            // 
            textBoxRepassword.Location = new Point(82, 212);
            textBoxRepassword.Name = "textBoxRepassword";
            textBoxRepassword.Size = new Size(210, 23);
            textBoxRepassword.TabIndex = 20;
            // 
            // lblRepassword
            // 
            lblRepassword.AutoSize = true;
            lblRepassword.ForeColor = Color.Black;
            lblRepassword.Location = new Point(4, 212);
            lblRepassword.Name = "lblRepassword";
            lblRepassword.Size = new Size(70, 15);
            lblRepassword.TabIndex = 19;
            lblRepassword.Text = "Repassword";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(82, 94);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 23);
            textBoxEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(4, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(82, 172);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 23);
            textBoxPassword.TabIndex = 16;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = Color.Black;
            Password.Location = new Point(4, 172);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 15;
            Password.Text = "Password";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(82, 52);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(210, 23);
            textBoxSurname.TabIndex = 14;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(4, 55);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 15);
            lblUserName.TabIndex = 13;
            lblUserName.Text = "User Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(82, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 23);
            textBoxName.TabIndex = 12;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 11;
            lblName.Text = "Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(82, 132);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(210, 23);
            textBoxRole.TabIndex = 23;
            // 
            // roleId
            // 
            roleId.AutoSize = true;
            roleId.Location = new Point(6, 135);
            roleId.Name = "roleId";
            roleId.Size = new Size(41, 15);
            roleId.TabIndex = 24;
            roleId.Text = "RoleID";
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(520, 61);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(138, 23);
            btnSearchUser.TabIndex = 29;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(520, 32);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(210, 23);
            textBoxSearch.TabIndex = 30;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(138, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(232, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearchUser);
            Controls.Add(roleId);
            Controls.Add(textBoxRole);
            Controls.Add(btnAdd);
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
            Controls.Add(userTable);
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userTable;
        private TextBox textBoxRepassword;
        private Label lblRepassword;
        private TextBox textBoxEmail;
        private Label lblEmail;
        private TextBox textBoxPassword;
        private Label Password;
        private TextBox textBoxSurname;
        private Label lblUserName;
        private TextBox textBoxName;
        private Label lblName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn UserPassword;
        private Button btnAdd;
        private TextBox textBoxSearchUsers;
        private TextBox textBoxRole;
        private Label roleId;
        private Label label1;
        private TextBox textBoxSearchUserById;
        private Label label2;
        private Button searchUsersByDeletedOrName;
        private Button btnSearchUser;
        private TextBox textBoxSearch;
        private Button button1;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn Deleted;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}