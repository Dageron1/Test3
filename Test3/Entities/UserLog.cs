namespace Test3.Entities;

public class UserLog
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public required string Description { get; set; }

    public User User { get; set; } = default!;
}
