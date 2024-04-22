using Notifications.Data;
using Notifications.Models;

namespace Notifications.Services;

public class NotificationService : INotificationService
{
  private static readonly Dictionary<Guid, Notification> _notifications = new();
  private readonly ApplicationDbContext _context;
  public NotificationService(ApplicationDbContext context)
  {
    _context = context;
  }
  public async Task<Notification> CreateNotification(Notification notification)
  {
    _context.Notifications.Add(notification);
    await _context.SaveChangesAsync();

    return notification;
  }

  public IQueryable<Notification> Get(Guid id)
  {
    return _context.Notifications.Where(n => n.Id == id);
  }
}