namespace Notifications.Models;

public class Notification
{
  public Guid Id { get; set; }
  public string Content { get; set; }
  public string CreatedBy { get; set; }


  private Notification(string content, string createdBy)
  {
    Content = content;
    CreatedBy = createdBy;
  }
  public static Notification Create(string Content, string CreatedBy)
  {
    return new Notification(Content, CreatedBy);
  }
}