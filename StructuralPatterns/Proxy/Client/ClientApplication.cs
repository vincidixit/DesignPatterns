using Proxy.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Client
{
    class ClientApplication
    {
        private readonly IUserService _userService;
        public ClientApplication(IUserService userService)
        {
            _userService = userService;
        }

        public void GetUserDetails(string username)
        {
            var user = _userService.GetUserDetails(username);
            Console.WriteLine($"User Name: {user.Name}");
            Console.WriteLine($"User Location: {user.Location}");
        }

    }
}
