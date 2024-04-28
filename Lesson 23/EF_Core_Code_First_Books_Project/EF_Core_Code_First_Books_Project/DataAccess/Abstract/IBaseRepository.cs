using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T: class, new()
    {
        void Add(T entity);

        T Get(int id);

        List<T> GetAll();

        void DeleteById(int id);

        void DeleteAll();

        void Update(T entity);
    }
}
