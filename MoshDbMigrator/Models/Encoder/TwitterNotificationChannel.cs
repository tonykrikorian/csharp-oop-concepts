using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.Encoder
{
    public class TwitterNotificationChannel : INotificationChannel
    {
        private readonly string _account;

        public TwitterNotificationChannel(string account)
        {
            this._account = account;
        }
        public void SendNotification(string message)
        {
            Console.WriteLine($"Twitter Account{_account}: {message}");
        }
    }
}
