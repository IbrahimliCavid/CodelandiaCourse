using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUser.Controls.Abstract;
using WindowsFormsUser.DataBase;
using WindowsFormsUser.Entity;

namespace WindowsFormsUser.Controls.Concret
{
    public class UserManager : IUserOperation
    {

        public static UserManager _instance;

        public static UserManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserManager();
                return _instance;
            }
        }

        public void Add(User item)
        {
            DB.Instance.users.Add(item);    
        }

        public List<User> GetAll()
        {
            return DB.Instance.users;
        }

        public User GetWithId(string id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveById(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(string id)
        {
            throw new NotImplementedException();
        }
    }
}