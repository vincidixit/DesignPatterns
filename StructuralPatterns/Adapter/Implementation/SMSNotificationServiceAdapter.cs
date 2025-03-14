using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementation
{
    class SMSNotificationServiceAdapter : INotificationService
    {
        private SMSNotificationService _smsNotificationService;
        public SMSNotificationServiceAdapter(SMSNotificationService smsNotificationService)
        {
            _smsNotificationService = smsNotificationService;
        }

        public void Notify(string recipient, string message)
        {
            _smsNotificationService.SendTextMessage(recipient, message);
        }
    }
}
