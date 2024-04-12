using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInAndSignUp.Entity
{
    public abstract class BaseEntity
    {
        private static int _id = 1;
        public int ID { get; set; }
        protected BaseEntity()
        {
            ID = _id++;
        }
    }
}