using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementation
{
    class SMSNotificationService : ILegacyNotificationService
    {
        public void SendTextMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient} with message: {message}");
        }
    }
}
