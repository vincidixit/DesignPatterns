using Proxy.Abstraction;
using Proxy.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementation
{
    public class UserService : IUserService
    {
        public User GetUserDetails(string username)
        {
            Console.WriteLine($"Retrieving details of {username} from the database");

            var user = RetrieveUserDetailsFromDatabase(username);

            return user;
        }

        public User RetrieveUserDetailsFromDatabase(string username)
        {
            Console.WriteLine($"Retrieving details of {username} from the database");
            return new User { Location = "Pune", Name = "Miguel O'Hara" };
        }
    }
}
