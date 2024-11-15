using NotificationServiceLibrary.Models;

namespace NotificationServiceLibrary.Providers
{
    public class EmailNotificationProvider : BaseNotificationProvider
    {
        public override async Task<NotificationResult> SendNotificationAsync(NotificationRequest request)
        {
            try
            {
                // Simulate SMTP sending
                await Task.Delay(500); // Non-blocking simulation
                return GenerateResult(request, true, "Email");
            }
            catch (Exception ex)
            {
                return GenerateResult(request, false, "Email", ex.Message);
            }
        }
    }
}
