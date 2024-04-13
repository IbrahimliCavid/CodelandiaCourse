using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUser.Entity;

namespace WindowsFormsUser.Controls.Abstract
{
    public interface IBaseOperation<T> where T: BaseEntity, new()
    {
        void Add(T item);

        List<T> GetAll();
        T GetWithId(string id);
        void RemoveAll();
        void RemoveById(string id);

        void UpdateById(string id);
    }
}
