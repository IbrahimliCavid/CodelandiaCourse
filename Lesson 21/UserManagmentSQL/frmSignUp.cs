using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagmentSQL.DataAccess.Concret;
using UserManagmentSQL.Entity;

namespace UserManagmentSQL
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new();
            if (lblRepassword.Text == lblRepassword.Text)
            {
                User user = new()
                {
                    Name = textBoxName.Text,
                    UserName = lblUserName.Text,
                    Email = lblEmail.Text,
                    Password = textBoxPassword.Text,
                };
                userRepository.Add(user);

                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Password incorrect!!");
            }



        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new();
            login.Show();
        }
    }
}
