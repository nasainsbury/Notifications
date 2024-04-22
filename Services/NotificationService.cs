using Microsoft.EntityFrameworkCore;
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

  public async Task<Notification> Get(Guid id)
  {
    return await _context.Notifications.Where(n => n.Id == id).FirstAsync<Notification>();
  }
}