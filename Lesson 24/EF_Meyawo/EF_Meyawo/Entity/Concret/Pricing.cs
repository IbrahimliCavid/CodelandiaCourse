using EF_Meyawo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.Entity.Concret
{
    public class Pricing : BaseEntity
    {
        public int ServiceID { get; set; }
        public decimal Price { get; set; }
        public virtual Service Service { get; set; }
    }
}
