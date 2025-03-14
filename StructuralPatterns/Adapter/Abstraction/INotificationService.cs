using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Abstraction
{
    interface INotificationService
    {
        void Notify(string recipient, string message);
    }
}
