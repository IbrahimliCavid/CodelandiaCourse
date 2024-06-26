﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentSQL.Entity.Abstract;

namespace UserManagmentSQL.Entity
{
    public class User : BaseEntity
    {
        public string Name {  get; set; }
      
        public string UserName {  get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public int Role { get; set; } = DefaultValues.DefaultValue.DFAULT_USER_ROLL_ID;
    }
}
