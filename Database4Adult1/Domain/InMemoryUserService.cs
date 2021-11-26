using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database4Adult1.Domain
{
    public class InMemoryUserService : IUserRepo
        {
            public List<User> users;

            public InMemoryUserService()
            {
                users = new[]
                {
                    new User
                    {
                        City = "Horsens",
                        Domain = "via.dk",
                        password = "123456",
                        Role = "Teacher",
                        BirthYear = 1986,
                        SecurityLevel = 5,
                        username = "Admin"
                    },
                    new User
                    {
                        City = "Aarhus",
                        Domain = "hotmail.com",
                        password = "123456",
                        Role = "Student",
                        BirthYear = 1998,
                        SecurityLevel = 3,
                        username = "Jakob"
                    },
                    new User
                    {
                        City = "Vejle",
                        Domain = "via.com",
                        password = "123456",
                        Role = "Guest",
                        BirthYear = 1973,
                        SecurityLevel = 1,
                        username = "Kasper"
                    }
                }.ToList();
            }


            public async Task<User> ValidateUser(string userName, string password) {
                User first = users.FirstOrDefault(user => user.username.Equals(userName));
                if (first == null) {
                    throw new Exception("User not found");
                }

                if (!first.password.Equals(password)) {
                    throw new Exception("Incorrect password");
                }

                return first;
            }
        
        }
    }