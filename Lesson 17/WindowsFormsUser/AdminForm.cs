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
    public partial class AdminForm : Form
    {
        public object Aplication { get; private set; }

        public AdminForm()
        {
            InitializeComponent();
        }




        private void AdminAddBtn_Click(object sender, EventArgs e)
        {

            if (
                nameByAdmin.Text.Trim() != "" &&
                userNameByAdmin.Text.Trim() != "" &&
                emailByAdmin.Text.Trim() != "" &&
                passByAdmin.Text.Trim() != "" &&
                rePassByAdmin.Text.Trim() != ""
               )
            {
                if (passByAdmin.Text == rePassByAdmin.Text)
                {

                    User newUser = new User()
                    {
                        Name = nameByAdmin.Text,
                        UserName = userNameByAdmin.Text,
                        Email = emailByAdmin.Text,
                        Password = rePassByAdmin.Text
                    };

                    ClearAllInput();
                    UserManager.Instance.Add(newUser);
                    WriteToTable();

                }
                else
                {
                    rePassByAdmin.Text = "";
                    rePassByAdmin.Text = "";
                    MessageBox.Show("The repassword is not correct!!!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the information completely!!!");
            }
        }


        private void ClearAllInput()
        {
            nameByAdmin.Text = "";
            userNameByAdmin.Text = "";
            emailByAdmin.Text = "";
            passByAdmin.Text = "";
            rePassByAdmin.Text = "";
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            WriteToTable();
        }

        private void WriteToTable()
        {
            var users = DB.Instance.users;
            userTable.Rows.Clear();
            if (userTable.Rows.Count < users.Count)
                userTable.Rows.Add(users.Count - userTable.Rows.Count);

            int i = 0;
            foreach (var item in users)
            {
                if (item.UserName != "admin")
                {
                    userTable.Rows[i].Cells[0].Value = item.ID;
                    userTable.Rows[i].Cells[1].Value = item.Name;
                    userTable.Rows[i].Cells[2].Value = item.UserName;
                    userTable.Rows[i].Cells[3].Value = item.Email;
                    userTable.Rows[i].Cells[4].Value = item.Password;
                    i++;

                }
                else
                {
                    continue;
                }
            }
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }



        private void RemoveRow(object sender, DataGridViewCellEventArgs e)
        {
            UserManager.Instance.RemoveAll();
            userTable.Rows.Clear();
        }

        private User SearchUser()
        {
            var users = DB.Instance.users;
            User userFind = users.Find(x => x.UserName == searchUserInput.Text);
            return userFind;
        }
        private void getUser_Click(object sender, EventArgs e)
        {

            User user = SearchUser();
            if (user != null)
            {
                nameByAdmin.Text = user.Name;
                userNameByAdmin.Text = user.UserName;
                emailByAdmin.Text = user.Email;
                passByAdmin.Text = user.Password;
                rePassByAdmin.Text = user.Password;

            }
            else
            {

                MessageBox.Show("User not defind!!!");

            }

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = SearchUser();
            if (user != null)
            {
                if (passByAdmin.Text == rePassByAdmin.Text)
                {
                    user.Name = nameByAdmin.Text;
                    user.Email = emailByAdmin.Text;
                    user.UserName = userNameByAdmin.Text;
                    user.Password = passByAdmin.Text;
                    WriteToTable();

                    ClearAllInput();

                }
                else
                {
                    MessageBox.Show("Repassword is incorrect!!!");
                }
            }



        }



        private void DeleteInputBtn_Click(object sender, EventArgs e)
        {
            var user = DB.Instance.users.Find(x => x.UserName == searchUserInput.Text);

            if (user != null)
            {
                UserManager.Instance.RemoveById(user.ID);
                WriteToTable();
                ClearAllInput();
                MessageBox.Show("User succesfuly deleted...");
            }
            else
            {
                MessageBox.Show("User not defind!!!");
            }
        }

        private void removeAllUserBtn_Click(object sender, EventArgs e)
        {
            UserManager.Instance.RemoveAll();
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
