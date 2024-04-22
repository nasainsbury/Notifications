using Notifications.Models;

namespace Notifications.Services;

public interface INotificationService
{
  Notification CreateNotification(Notification notification);
  Notification Get(Guid id);
}