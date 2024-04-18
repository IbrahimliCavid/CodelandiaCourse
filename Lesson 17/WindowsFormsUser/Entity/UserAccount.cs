using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUser.DataBase;

namespace WindowsFormsUser.Entity
{
    public class UserAccount 
    {
        public User user { get; set; }
        private static UserAccount _instance;
        public static UserAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserAccount();
                return _instance;
            }
        }



    }
}
