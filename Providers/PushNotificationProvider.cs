using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.Providers
{
    public class PushNotificationProvider : BaseNotificationProvider
    {
        public override async Task<NotificationResult> SendNotificationAsync(NotificationRequest request)
        {
            try
            {
                // Simulate Push notification API call
                await Task.Delay(500);
                return GenerateResult(request, true, "Push");
            }
            catch (Exception ex)
            {
                return GenerateResult(request, false, "Push", ex.Message);
            }
        }
    }
}
