using System;
using System.Collections.Generic;
using System.Linq;
using HandIn_1.Models;

namespace HandIn_1.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    City = "Aarhus", Domain = "gmail.com", Password = "111111", Role = "Admin", BirthYear = 1998,
                    SecurityLevel = 2, UserName = "Ion",UserId = 2
                },

            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}