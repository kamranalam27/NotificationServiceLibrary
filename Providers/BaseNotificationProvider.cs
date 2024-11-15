using NotificationServiceLibrary.Interfaces;
using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.Providers
{
    public abstract class BaseNotificationProvider : INotificationProvider
    {
        public abstract Task<NotificationResult> SendNotificationAsync(NotificationRequest request);

        protected NotificationResult GenerateResult(NotificationRequest request, bool success, string provider, string error = "")
        {
            return new NotificationResult
            {
                NotificationId = Guid.NewGuid(),
                Recipient = request.Recipient,
                Success = success,
                Provider = provider,
                ErrorMessage = error
            };
        }
    }
}
