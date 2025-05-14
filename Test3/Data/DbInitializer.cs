using Microsoft.EntityFrameworkCore;

namespace Test3.Data;

public class DbInitializer : IDbInitializer
{
    private readonly UserLogsDbContext _context;

    public DbInitializer(UserLogsDbContext context)
    {
        _context = context;
    }

    public async Task InitializeAsync()
    {
        if (await _context.Database.EnsureCreatedAsync())
        {
            if (!await _context.Users.AnyAsync())
            {
                await _context.Users.AddRangeAsync(UserSeeder.SeedUsers());
                await _context.SaveChangesAsync();
            }

            if (!await _context.UserLogs.AnyAsync())
            {
                await _context.UserLogs.AddRangeAsync(LogSeeder.SeedLogs());
                await _context.SaveChangesAsync();
            }
        }
    }
}
