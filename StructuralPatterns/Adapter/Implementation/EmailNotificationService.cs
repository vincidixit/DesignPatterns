using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementation
{
    class EmailNotificationService : INotificationService
    {
        public void Notify(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient} with message: {message}");
        }
    }
}
