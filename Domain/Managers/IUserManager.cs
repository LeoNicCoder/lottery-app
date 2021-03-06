﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Managers
{
    public interface IUserManager: IBaseManager<User>
    {
        public User GetByUsernameOrEmail(string term);
        public User GetByUsername(string username);
        public User GetByUsernameWithRole(string username);
        public User GetByEmail(string email);
        public User GetByUsernameOrEmailWithRole(string term);
        public User GetWithRole(long id);
    }
}
