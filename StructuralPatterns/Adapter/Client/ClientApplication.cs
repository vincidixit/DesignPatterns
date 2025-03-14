using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Client
{
    class ClientApplication
    {
        private readonly INotificationService _notificationService;
        
        public ClientApplication(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification(string recipient, string message)
        {
            _notificationService.Notify(recipient, message);
        }
    }
}
