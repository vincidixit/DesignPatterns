using Proxy.Abstraction;
using Proxy.Client;
using Proxy.Implementation;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new CachableUserService();
            var client = new ClientApplication(userService);

            // This will return the user details from the database
            client.GetUserDetails("miguel_earth_2099");

            // This will return the user details from the cache
            client.GetUserDetails("miguel_earth_2099");
        }
    }
}
