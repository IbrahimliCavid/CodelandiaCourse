using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.Entity.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Deleted {  get; set; }
        public DateTime CreateDate { get; set; }
    }
}
