using Microsoft.EntityFrameworkCore;

using Test3.Entities;

namespace Test3.Data;

public class UserLogsDbContext : DbContext
{
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserLog> UserLogs { get; set; }

    public UserLogsDbContext(DbContextOptions<UserLogsDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().OwnsOne(u => u.MailingAddress);
        modelBuilder.Entity<User>().OwnsOne(u => u.BillingAddress);
    }
}
