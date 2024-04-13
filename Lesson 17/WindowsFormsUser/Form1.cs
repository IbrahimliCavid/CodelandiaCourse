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
                nameTxt.Text != "" &&
                usernameTxt.Text != "" &&
                emailTxt.Text != "" &&
                passwordTxt.Text !=""&&
                rePasswordTxt.Text !="" 
               )
            {
                if (robotCheck.Checked)
                {
                    if (passwordTxt.Text == rePasswordTxt.Text)
                    {
                        User newUser = new User()
                        {
                            Name = nameTxt.Text,
                            UserName = usernameTxt.Text,
                            Email = emailTxt.Text,
                            Password = passwordTxt.Text
                        };

                        UserManager.Instance.Add(newUser);
                      
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        passwordTxt.Text = "";
                        rePasswordTxt.Text = "";
                        MessageBox.Show("The repassword is not correct");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Prove you're not a robot!!!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the information completely!!!");
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           
            Login login = new Login();
            login.Show();
        }
    }
}
