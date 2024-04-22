using Microsoft.EntityFrameworkCore;
using Notifications.Models;

namespace Notifications.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Notification> Notifications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Notification>()
          .Property(n => n.Id)
          .ValueGeneratedOnAdd();
    }
  }
}