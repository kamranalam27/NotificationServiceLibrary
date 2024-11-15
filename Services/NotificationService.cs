using NotificationServiceLibrary.Interfaces;
using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.Services
{
    public class NotificationService : INotificationService
    {
        private readonly Dictionary<NotificationType, INotificationProvider> _providers;

        public NotificationService(Dictionary<NotificationType, INotificationProvider> providers)
        {
            _providers = providers;
        }
        public async Task<List<NotificationResult>> SendNotificationsAsync(List<NotificationRequest> requests)
        {
            var tasks = requests.Select(request =>
            {
                if (_providers.TryGetValue(request.Type, out var provider))
                {
                    return provider.SendNotificationAsync(request);
                }
                else
                {
                    return Task.FromResult(new NotificationResult
                    {
                        NotificationId = Guid.NewGuid(),
                        Recipient = request.Recipient,
                        Success = false,
                        Provider = "Unknown",
                        ErrorMessage = "Unsupported notification type."
                    });
                }
            });

            var results = await Task.WhenAll(tasks).ConfigureAwait(false);
            return results.ToList();
        }

    }
}
