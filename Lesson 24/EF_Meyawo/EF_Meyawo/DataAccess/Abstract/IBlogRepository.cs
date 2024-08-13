using EF_Meyawo.Entity.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.DataAccess.Abstract
{
    public interface IBlogRepository : IMainRepository<Blog>
    {
    }
}
