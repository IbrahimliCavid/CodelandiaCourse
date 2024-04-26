using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;
using UserManagmentSQL.DataAccess.Concret;
using UserManagmentSQL.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            UserRepository userRepository = new UserRepository();

            User user = new User()
            {
                Name = textBoxName.Text,
                UserName = textBoxUsername.Text,
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text,
            };

            userRepository.Add(user);
        }
    }
}
