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

        private void WriteToTable(List<User> users)
        {
           

            userTable.Rows.Clear();
            if (userTable.Rows.Count < users.Count)
                userTable.Rows.Add(users.Count - userTable.Rows.Count);

            int i = 0;
            foreach (var item in users)
            {
                if (item.Role != 2)
                {
                    userTable.Rows[i].Cells[0].Value = item.Id;
                    userTable.Rows[i].Cells[1].Value = item.Name;
                    userTable.Rows[i].Cells[2].Value = item.UserName;
                    userTable.Rows[i].Cells[3].Value = item.Email;
                    userTable.Rows[i].Cells[4].Value = item.Password;
                    userTable.Rows[i].Cells[5].Value = item.Deleted;
                    userTable.Rows[i].Cells[6].Value = item.CreateDate;
                    i++;
                }
                else
                {
                    continue;
                }
            }
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
                if (user.Deleted !=0)
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
    }
}
