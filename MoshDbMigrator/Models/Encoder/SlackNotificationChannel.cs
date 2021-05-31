using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.Encoder
{
    public class SlackNotificationChannel : INotificationChannel
    {
        private readonly string _account;
        private readonly string _group;

        public SlackNotificationChannel(string account,string group)
        {
            this._account = account;
            this._group = group;
        }
        public void SendNotification(string message)
        {
            Console.WriteLine($"Slack Group {_group} to {_account} Message:{message}");
        }
    }
}
