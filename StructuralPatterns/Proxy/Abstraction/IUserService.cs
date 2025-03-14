using Proxy.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Abstraction
{
    public interface IUserService
    {
        User GetUserDetails(string username);
    }
}
