﻿using CloudCustomers.API.Interface;
using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}