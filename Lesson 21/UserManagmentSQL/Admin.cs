using Microsoft.VisualBasic.ApplicationServices;
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
using User = UserManagmentSQL.Entity.User;

namespace UserManagmentSQL
{
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            UserRepository userRepository = new();

            List<User> users = userRepository.Get();
            WriteToTable(users);
        }

        private void WriteToTable<T>(List<T> item)
        {


            userTable.DataSource = null;
            userTable.DataSource = item;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new();
            if (textBoxRepassword.Text == textBoxRepassword.Text)
            {
                User user = new()
                {
                    Name = textBoxName.Text,
                    UserName = lblUserName.Text,
                    Email = lblEmail.Text,
                    Password = textBoxPassword.Text,
                    Role = int.Parse(textBoxRole.Text),
                };
                userRepository.Add(user);

                ClearAllInput();
                List<User> users = userRepository.Get();
                WriteToTable(users);
            }
            else
            {
                MessageBox.Show("Password incorrect!!");
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new();
            List<User> users = userRepository.Get().Where(x =>
            x.Name == textBoxSearch.Text ||
            x.UserName == textBoxSearch.Text ||
            x.Email == textBoxSearch.Text
            ).ToList();

            User user = userRepository.Get().Find(x =>
            x.UserName == textBoxSearch.Text ||
            x.Email == textBoxSearch.Text
            );

            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxSurname.Text = user.UserName;
                textBoxRepassword.Text = user.Password;
                textBoxRole.Text = Convert.ToString(user.Role);
                textBoxEmail.Text = user.Email;
                textBoxPassword.Text = user.Password;
                WriteToTable(users);
                if (user.Deleted != 0)
                {
                    MessageBox.Show("Not!!!\n User was deleted!!!");
                }
            }
            else
            {
                MessageBox.Show("User not find!!!");
            }








        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new();
            User user = userRepository.Get().Find(x =>
           x.UserName == textBoxSearch.Text ||
           x.Email == textBoxSearch.Text
           );
            userRepository.Delete(user.Id);
            ClearAllInput();
            WriteToTable(userRepository.Get());
        }

        private void ClearAllInput()
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxRepassword.Text = "";
            textBoxRole.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new();

            if (textBoxPassword.Text == textBoxRepassword.Text)
            {
                User user = new()
                {
                    Name = textBoxName.Text,
                    UserName = textBoxSurname.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                    Role = int.Parse(textBoxRole.Text)
                };
                userRepository.Update(user);
                ClearAllInput();
                WriteToTable(userRepository.Get());
            }
            else
            {
                MessageBox.Show("Password incorrected!!!");
            }






        }

        private void ShowRole_Click(object sender, EventArgs e)
        {
            List<Role> roles = new List<Role>();
            WriteToTable(roles);
        }
    }
}
