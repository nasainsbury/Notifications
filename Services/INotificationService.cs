using Notifications.Models;

namespace Notifications.Services;

public interface INotificationService
{
  Task<Notification> CreateNotification(Notification notification);
  IQueryable<Notification> Get(Guid id);
}