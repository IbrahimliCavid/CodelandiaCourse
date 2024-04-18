using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUser.Controls.Concret;
using WindowsFormsUser.DataBase;
using WindowsFormsUser.Entity;

namespace WindowsFormsUser
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
           
        }

        private void Account_Load(object sender, EventArgs e)
        {
            
            var account = UserAccount.Instance.user;
            FullName.Text = account.Name;
            nameInput.Text = account.Name;
            userNameInput.Text = account.UserName;
            emailInput.Text = account.Email;
            passwordInput.Text = account.Password;
            rePasswordInput.Text = account.Password;
        }

        private void exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var account = UserAccount.Instance.user;
            var user = DB.Instance.users.Find(x => x.ID == account.ID);
            if (passwordInput.Text == rePasswordInput.Text )
            {
                user.Name = nameInput.Text;
                user.Email = emailInput.Text;
                user.UserName = userNameInput.Text;
                user.Password = passwordInput.Text;
                MessageBox.Show("Update successfuly...");
            }
            else
            {
                MessageBox.Show("Repassword is incorrect!!!");
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var account = UserAccount.Instance.user;
            UserManager.Instance.RemoveById(account.ID);
            MessageBox.Show("Account successfuly removed...");
            back_LinkClicked(null, null);
        }
    }
}
