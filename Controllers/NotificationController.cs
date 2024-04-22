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
  public async Task<IActionResult> CreateNotification([FromBody] PostNotificationBody body)
  {
    Notification notification = Notification.Create(Content: body.Content, CreatedBy: body.CreatedBy);
    Notification created = await _notificationService.CreateNotification(notification);

    return Ok(created);
  }

  [HttpGet("/notification/{id:guid}")]
  public async Task<IActionResult> GetNotification(Guid id)
  {
    Notification notification = await _notificationService.Get(id);
    return Ok(notification);
  }
}