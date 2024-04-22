namespace Notifications.Models;

public class Notification
{
  public Guid Id { get; set; }
  public string Content { get; set; }
  public string CreatedBy { get; set; }


  private Notification(Guid id, string content, string createdBy)
  {
    Id = id;
    Content = content;
    CreatedBy = createdBy;
  }
  public static Notification Create(Guid Id, string Content, string CreatedBy)
  {
    return new Notification(Id, Content, CreatedBy);
  }
}