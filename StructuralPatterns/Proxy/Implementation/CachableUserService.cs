using Proxy.Abstraction;
using Proxy.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementation
{
    public class CachableUserService : IUserService
    {
        private readonly UserService _service;

        private readonly MemoryCache memoryCache = MemoryCache.Default;

        public CachableUserService()
        {
            _service = new UserService();
        }

        public User GetUserDetails(string username)
        {
            string cacheKey = $"User_{username}";

            var user = memoryCache.Get(cacheKey) as User;

            if (user != null)
            {
                Console.WriteLine($"Returning user {username} from cache");
                return user;
            }

            user = _service.GetUserDetails(username);

            if (user != null)
            {
                memoryCache.Add(cacheKey, user, DateTimeOffset.UtcNow.AddMinutes(5));
            }

            return user;
        }
    }
}
