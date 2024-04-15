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
using WindowsFormsUser.Entity;

namespace WindowsFormsUser
{
    public partial class Form1 : Form
    {
        Login login = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {


            if (
                nameTxt.Text.Trim() != "" && 
                usernameTxt.Text.Trim() != "" &&
                emailTxt.Text.Trim() != "" &&
                passwordTxt.Text.Trim() !=""&&
                rePasswordTxt.Text.Trim() !="" 
               )
            {
                IsChecked(); 
            }
            else
            {
                MessageBox.Show("Fill in the information completely!!!");
            }
        }

        private void IsChecked()
        {
            if (robotCheck.Checked)
            {

                PasswordControl();
            }
            else
            {
                MessageBox.Show("Prove you're not a robot!!!");
            }
        }

        private void PasswordControl()
        {
            if (passwordTxt.Text == rePasswordTxt.Text)
            {
                this.Hide();
                login.Show();
                User newUser = new User()
                {
                    Name = nameTxt.Text,
                    UserName = usernameTxt.Text,
                    Email = emailTxt.Text,
                    Password = passwordTxt.Text
                };


                UserManager.Instance.Add(newUser);
              
            }
            else
            {
                passwordTxt.Text = "";
                rePasswordTxt.Text = "";
                MessageBox.Show("The repassword is not correct!!!");
            }
        }
        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            login.Show();
        }
    }
}
