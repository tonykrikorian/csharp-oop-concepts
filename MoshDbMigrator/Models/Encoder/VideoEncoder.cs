using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.Encoder
{
    public class VideoEncoder
    {
        private IList<INotificationChannel> _notificationsChannel;

        public VideoEncoder()
        {
            _notificationsChannel = new List<INotificationChannel>();
        }
        public void Encode(Video video) 
        {
            Console.WriteLine("Encoded video !!");

            foreach(var channel in _notificationsChannel) 
            {
                channel.SendNotification($"Se ha completado el encoding del video {video.Name}");
            }
        }

        public void AddNotificationChannel(INotificationChannel notification) 
        {
            _notificationsChannel.Add(notification);
        }
    }
}
