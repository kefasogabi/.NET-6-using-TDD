using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User()
                {
                    Id = 1,
                    Name = "Jane 1",
                    Address = new Address()
                    {
                        Street = "123 main st 1",
                        City = "Madison 1",
                        ZipCode = "12345"
                    },
                    Email = "jane1@example.com"
                },
                new User()
                {
                    Id = 2,
                    Name = "Jane 2",
                    Address = new Address()
                    {
                        Street = "123 main st 2",
                        City = "Madison 2",
                        ZipCode = "12345"
                    },
                    Email = "jane2@example.com"
                },
                new User()
                {
                    Id = 3,
                    Name = "Jane 3",
                    Address = new Address()
                    {
                        Street = "123 main st 3",
                        City = "Madison 3",
                        ZipCode = "12345"
                    },
                    Email = "jane3@example.com"
                } 
            };
       
    }
}
