using Notifications.Models;

namespace Notifications.Services;

public class NotificationService : INotificationService
{
  private static readonly Dictionary<Guid, Notification> _notifications = new();
  public Notification CreateNotification(Notification notification)
  {
    _notifications.Add(notification.Id, notification);

    return notification;
  }
}