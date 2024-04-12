using SignInAndSignUp.Controls.Abstract;
using SignInAndSignUp.DataBase;
using SignInAndSignUp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInAndSignUp.Controls.Concret
{
    public class UserManager : IBaseOperation<User>, IUserOperation
    {
        public bool Add(User entity)
        {
            if (entity == null)
                return false;

            DB.DataBase.users.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var deletedEntity = DB.DataBase.users.Find(x => x.ID == id);
            if (deletedEntity == null)
                return false;

            DB.DataBase.users.Remove(deletedEntity);
            return true;
        }

        public List<User> GetAll()
        {
            var allUsers = DB.DataBase.users;
            return allUsers;
        }

        public User GetById(int id)
        {
            var foundEntity = DB.DataBase.users.Find(x => x.ID == id);
            return foundEntity;
        }

        public bool HasUser(User user, out User outUser)
        {
            var isUser = DB.DataBase.users
                .Find(
                x => x.UserName == user.UserName &&
                x.Password == user.Password
                );
            outUser = isUser;
            if (isUser == null)
                return false;

            return true;
        }

        public bool Update(User newUser)
        {
            var oldEntity = DB.DataBase.users.Find(x => x.ID == newUser.ID);

            if (oldEntity == null)
                return false;

            oldEntity.UserName = newUser.UserName;
            oldEntity.Email = newUser.Email;
            oldEntity.Password = newUser.Password;
            return true;
        }

        public void RemoveAllUser()
        {
            var admin = DB.DataBase.users.Find(x => x.UserName == "admin");
            DB.DataBase.users.Clear();
            DB.DataBase.users.Add(admin);
        }

        
    }
}