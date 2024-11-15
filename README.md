# NotificationServiceLibrary

## Overview

This project implements a Notification Service that can send Email, Push Notifications, and is designed to be easily 
extensible to support other notification types like SMS and Slack etc. 

The service is designed to be used as a C# class library, which can be plugged into various applications, ensuring 
easy integration, scalability, and maintainability.

## Key Features

- **Extensible**: Easily extendable to support new notification providers (e.g., SMS, Slack, etc.).

- **Non-blocking**: The service processes notifications asynchronously, ensuring that the system remains responsive.

- **Error Handling**: Handles failure cases gracefully, such as when a notification provider is unreachable.

- **Clean Code**: Follows SOLID principles and design patterns (like the **Decorator Pattern**) for maintainability and 
flexibility

## Project Structure

1. NotificationServiceLibrary (C# Class Library)
- **Models**: Contains models for request and result objects, such as `NotificationRequest` and `NotificationResult`.
- 
- **Services**: The core service (`NotificationService`) responsible for managing and sending notifications through 
registered providers.
- 
- **Providers**: Contains implementations of different notification providers (e.g., `EmailNotificationProvider`, 
`PushNotificationProvider`).
 
2. NotifyManagerConsole (Test Application – C# Console APP)

A console application to test the notification service library. It simulates the sending of different types of 
notifications and logs the results


## Testing Scenarios

- **Testing Multiple Providers**

You can test the notification service with multiple providers by creating different 
NotificationRequest objects and passing them to the NotificationService.

var emailRequest = new NotificationRequest
{
 Type = NotificationType.Email,
 Recipient = "iamkamran27@gmail.com",
 Message = "Test Email Notification"
};

var pushRequest = new NotificationRequest
{
 Type = NotificationType.Push,
 Recipient = "+923302533681",
 Message = "Test Push Notification"
};

var requests = new List<NotificationRequest> { emailRequest, pushRequest };
var results = await notificationService.SendNotificationsAsync(requests);


- **Handling Failures**

If a notification fails (e.g., due to a bad recipient or a network issue), the service will catch the 
exception and return an error in the result.


- **Bulk Notifications**

You can send a batch of notifications by creating multiple NotificationRequest objects and passing 
them to the NotificationService.

var bulkRequests = Enumerable.Range(1, 100).Select(i => new NotificationRequest
{
 Type = NotificationType.Email,
 Recipient = $"user{i}@example.com",
 Message = $"Bulk notification #{i}"
}).ToList();

var results = await notificationService.SendNotificationsAsync(bulkRequests)


# Running the Console App
1. Clone the repository or download the solution.
2. Build the solution in Visual Studio.
3. Run the Console Application to simulate sending notifications.
The console application will show the results of sending different types of notifications (Email, 
Push) to different recipients.


# Future Enhancements

## Support for Additional Notification Providers:
o Implement new providers such as SMS, Slack, and Webhook.
## Database Integration:
o Optionally, the notification service can be extended to log results to a database or 
integrate with external systems.
## Advanced Error Handling:
o Improve error handling to support retry logic, circuit breakers, etc.


# Conclusion
This notification service provides a flexible, extensible, and non-blocking architecture for 
handling different types of notifications (Email, Push, etc.). It is designed to be easily integrated 
into any system, and its extensibility ensures that additional notification types can be added 
seamlessly in the future.