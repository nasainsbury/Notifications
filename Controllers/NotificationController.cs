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

  [HttpPost("/notification")]
  public IActionResult CreateNotification([FromBody] PostNotificationBody body)
  {
    Notification notification = Notification.Create(Id: Guid.NewGuid(), Content: body.Content, CreatedBy: body.CreatedBy);
    Notification created = _notificationService.CreateNotification(notification);

    return Ok(created);
  }

  [HttpGet("/notification/{id:guid}")]
  public IActionResult GetNotification(Guid id)
  {
    Notification notification = _notificationService.Get(id);
    return Ok(notification);
  }
}