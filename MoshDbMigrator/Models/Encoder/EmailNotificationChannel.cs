using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.Encoder
{
    public class EmailNotificationChannel : INotificationChannel
    {
        private readonly string _emailSender;
        private readonly string _emailRecipiente;

        public EmailNotificationChannel(string emailSender,string emailRecipiente)
        {
            this._emailSender = emailSender;
            this._emailRecipiente = emailRecipiente;
        }
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email sended to: {_emailRecipiente} from {_emailSender}");
        }
    }
}
