﻿using SignInAndSignUp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInAndSignUp.Controls.Abstract
{
    public interface IUserOperation
    {
        bool HasUser(User user, out User outUser);
    }
}