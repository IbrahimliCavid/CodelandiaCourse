using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.DefaultValues
{
    public static class DefaultValue
    {

        public static  DateTime DEFAULT_DATETIME_VALUE { get; set; } = DateTime.Now;

        public static readonly int DEFAULT_DELETED_VALUE = 0;
    }
}
