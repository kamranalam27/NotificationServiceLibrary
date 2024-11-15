using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.Interfaces
{
    public interface INotificationProvider
    {
        Task<NotificationResult> SendNotificationAsync(NotificationRequest request);
    }
}
