﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentSQL.Entity.Abstract;

namespace UserManagmentSQL.Entity
{
    public class Account : BaseEntity
    {
        public int UserId { get; set; }
    }
}
