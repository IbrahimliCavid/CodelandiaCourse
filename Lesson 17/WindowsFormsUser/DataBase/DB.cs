using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUser.Entity;

namespace WindowsFormsUser.DataBase
{
    public class DB
    {
        private static DB _instance;
        public static DB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DB();
                return _instance;
            }
        }

      public List<User> users = new List<User>();
       
    }
}
