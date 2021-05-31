namespace MoshDbMigrator.Models.Encoder
{
    public interface INotificationChannel
    {
        void SendNotification(string message);
    }
}
