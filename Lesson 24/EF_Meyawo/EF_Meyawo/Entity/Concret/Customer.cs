using EF_Meyawo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.Entity.Concret
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName {  get; set; }
        public DateTime BrithDate { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
    }
}
