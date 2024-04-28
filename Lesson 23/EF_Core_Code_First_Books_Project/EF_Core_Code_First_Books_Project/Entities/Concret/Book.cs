using EF_Core_Code_First_Books_Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.Entities.Concret
{
    public class Book : BaseEntity
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public short Page {  get; set; }

        public int Price { get; set; }

        public int AuthorId {  get; set; }

        public virtual Author Author { get; set; }
    }
}
