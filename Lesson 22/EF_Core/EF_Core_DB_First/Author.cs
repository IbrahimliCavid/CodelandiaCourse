using System;
using System.Collections.Generic;

namespace EF_Core_DB_First
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
