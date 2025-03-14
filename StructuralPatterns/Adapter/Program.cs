using Adapter.Abstraction;
using Adapter.Client;
using Adapter.Implementation;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService notificationService = GetLegacySMSServiceAdapter();

            var client = new ClientApplication(notificationService);
            client.SendNotification("9876543210", "Your transaction is successful.");
        }

        private static INotificationService GetLegacySMSServiceAdapter()
        {
            var smsNotificationService = new SMSNotificationService();
            return new SMSNotificationServiceAdapter(smsNotificationService);
        }
    }
}
