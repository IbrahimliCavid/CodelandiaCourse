using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profile
{
    internal class UserManager
    {
        private List<User> Users { get; set }
        public UserManager(List<User> users) {
            Users = users;     
        }

        public List<User> SignIn()
        {


          return Users;
        }

        public void SignUp(User user)
        {
            Users.Add(user);
        }


        
    }
}
