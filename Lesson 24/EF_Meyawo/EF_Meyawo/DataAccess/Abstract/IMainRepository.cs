using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.DataAccess.Abstract
{
    public interface IMainRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T GetByID(int id);

        List<T> GetAll();   

    }
}
