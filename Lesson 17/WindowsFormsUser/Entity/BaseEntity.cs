using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUser.Entity
{
    public class BaseEntity
    {
        readonly string ID = Guid.NewGuid().ToString();
    }
}
