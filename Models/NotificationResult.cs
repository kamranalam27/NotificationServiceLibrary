
namespace NotificationServiceLibrary.Models
{
    public class NotificationResult
    {
        public Guid NotificationId { get; set; }
        public string? Recipient { get; set; }
        public bool Success { get; set; }
        public string? Provider { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
