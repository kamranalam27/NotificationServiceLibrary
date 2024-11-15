
namespace NotificationServiceLibrary.Models
{
    public class NotificationRequest
    {
        public string? Recipient { get; set; }
        public string? Message { get; set; }
        public NotificationType Type { get; set; }
    }
}
