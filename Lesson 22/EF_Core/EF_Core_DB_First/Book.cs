using System;
using System.Collections.Generic;

namespace EF_Core_DB_First
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int AuthorId { get; set; }
        public short PageOf { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}
