using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUser.Entity
{
    public class Account
    {
        private User _account;

        public Account(User account)
        {
            _account = account;
        }

        public User getAccount()
        {
            return _account;
        }
    }
}
