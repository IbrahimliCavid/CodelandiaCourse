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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new();

            List<User> userList = userRepository.Get();

            var user = userList.Find(x => x.UserName == textBoxUserName.Text && x.Password == textBoxPassword.Text);
           

            if (user != null)
            {
                this.Hide();
                if (user.Role == 1)
                {
                    Account account = new();
                    account.Show();
                }else if (user.Role == 2){
                    Admin admin = new();
                    admin.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or password incorrected!!!");
            }
        }
    }
}
