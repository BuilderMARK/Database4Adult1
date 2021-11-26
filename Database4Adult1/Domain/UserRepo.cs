using System;
using System.Linq;
using System.Threading.Tasks;
using Database4Adult1.Persistence;

namespace Database4Adult1.Domain
{
    public class UserRepo : IUserRepo
    {
        
        private InMemoryUserService _inMemoryUserService;

        
        protected AdultContext ctx;
        
        public void Setup()
        {
            ctx = new AdultContext();
        }
        
        
        
        public async Task<User> ValidateUser(string username, string password)
        {
            User first = _inMemoryUserService.users.FirstOrDefault(user => user.username.Equals(username));
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