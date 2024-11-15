using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.Interfaces
{
    public interface INotificationService
    {
        Task<List<NotificationResult>> SendNotificationsAsync(List<NotificationRequest> requests);
    }
}
