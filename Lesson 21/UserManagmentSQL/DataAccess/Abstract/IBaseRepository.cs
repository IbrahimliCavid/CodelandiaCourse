using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentSQL.Entity.Abstract;

namespace UserManagmentSQL.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : class, new()
    {
        T Get(int id);
        List<T> Get();
        void Add(T entity);
        void Delete(int id);

        void Update(T entity);
    }
}
