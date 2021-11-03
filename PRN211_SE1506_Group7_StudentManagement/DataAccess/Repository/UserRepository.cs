﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<UserObject> GetUsers() => UserDAO.Instance.GetUserList();
    }
}
