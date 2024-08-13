using EF_Meyawo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.Entity.Concret
{
    public class Portfoilo :BaseEntity
    {
        public string Description {  get; set; }

        public int ImageID {  get; set; }

        public virtual Image Image { get; set; }
    }
}
