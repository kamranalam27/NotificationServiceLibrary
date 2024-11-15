using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.DB
{
    public static class NotificationDatabase
    {
        public static List<NotificationResult> NotificationLog { get; } = new List<NotificationResult>();

        public static void SaveNotification(NotificationResult result)
        {
            NotificationLog.Add(result);
        }
    }
}
