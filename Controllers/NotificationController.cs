using Microsoft.AspNetCore.Mvc;
using Notifications.Models;
using Notifications.Services;

public class NotificationController : ControllerBase
{
  private readonly INotificationService _notificationService;
  public NotificationController(INotificationService notificationService)
  {
    _notificationService = notificationService;
  }

  [HttpGet("/cool")]
  public IActionResult CreateNotification()
  {
    Notification notification = Notification.Create(Id: Guid.NewGuid(), Content: "a", CreatedBy: "a");
    Notification created = _notificationService.CreateNotification(notification);

    return Ok(created);
  }
}