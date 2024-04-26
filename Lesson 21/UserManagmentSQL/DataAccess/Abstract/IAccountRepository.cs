using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentSQL.Entity;

namespace UserManagmentSQL.DataAccess.Abstract
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
    }
}
