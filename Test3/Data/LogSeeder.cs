using Test3.Entities;

namespace Test3.Data;

public static class LogSeeder
{
    public static List<UserLog> SeedLogs() => new()
    {
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F15-7000-9A6C-123456789A00"),
            UserId = Guid.Parse("018F0E79-5F10-7000-8B55-B2F01B93A100"), // USER A
            Description = "Logged in"
        },
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F16-7000-9123-234567891B00"),
            UserId = Guid.Parse("018F0E79-5F10-7000-8B55-B2F01B93A100"),
            Description = "Viewed dashboard"
        },
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F17-7000-8ACD-345678912C00"),
            UserId = Guid.Parse("018F0E79-5F10-7000-8B55-B2F01B93A100"),
            Description = "Logged out"
        },
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F18-7000-934E-456789123D00"),
            UserId = Guid.Parse("018F0E79-5F11-7000-97A7-2F0D45D5A200"), // USER B
            Description = "Password changed"
        },
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F19-7000-9ABF-567891234E00"),
            UserId = Guid.Parse("018F0E79-5F14-7000-847F-FD23C3B0A500"), // SYSTEM USER
            Description = "Updated settings"
        },
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F1A-7000-8123-678912345F00"),
            UserId = Guid.Parse("018F0E79-5F14-7000-847F-FD23C3B0A500"),
            Description = "Generated report"
        },
        new UserLog
        {
            Id = Guid.Parse("018F0E79-5F1B-7000-8D4E-789123456A00"),
            UserId = Guid.Parse("018F0E79-5F14-7000-847F-FD23C3B0A500"),
            Description = "System rebooted"
        }
    };
}
