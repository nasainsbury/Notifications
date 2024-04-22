using Notifications.Models;

namespace Notifications.Services;

public interface INotificationService
{
  Task<Notification> CreateNotification(Notification notification);
  Task<Notification> Get(Guid id);
}