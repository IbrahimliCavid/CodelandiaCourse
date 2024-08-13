using EF_Meyawo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.Entity.Concret
{
    public class Comment : BaseEntity
    {
        public string Text {  get; set; }
        public int CustomerId {  get; set; }
        public int BlogID {  get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
