using EF_Core_Code_First_Books_Project.DefaultValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int Deleted { get; set; } = DefaultValue.DEFAULT_DELETED_VALUE;

        public DateTime CreateDate { get; set; } = DefaultValue.DEFAULT_DATETIME_VALUE;
    }
}
