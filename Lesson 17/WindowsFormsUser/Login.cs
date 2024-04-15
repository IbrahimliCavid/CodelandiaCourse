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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private List<User> Login_Load(object sender, EventArgs e)
        {
            return UserManager.Instance.GetAll();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            List<User> users = UserManager.Instance.GetAll();
            var user = users.Find(x => (x.Email == emailOrUsername.Text || x.UserName == emailOrUsername.Text) && x.Password == loginPassword.Text);
            if (user != null)
            {
                MessageBox.Show("Login Succesfuly");
                
            }
            else
            {

                MessageBox.Show("Username or password incorrect!!!");
            }

        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 signUp = new Form1();
            signUp.Show();
        }
    }
}
