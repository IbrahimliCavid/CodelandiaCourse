using EF_Core_Code_First_Books_Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.Entities.Concret
{
    public class Nationality : BaseEntity
    {
        public string Name {  get; set; }
    }
}
