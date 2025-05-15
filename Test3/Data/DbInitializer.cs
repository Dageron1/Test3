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
                var users = await UserSeeder.LoadUsersFromJsonAsync("Data/users.json");
                await _context.Users.AddRangeAsync(users);
                await _context.SaveChangesAsync();
            }

            if (!await _context.UserLogs.AnyAsync())
            {
                var logs = await LogSeeder.LoadLogsFromJsonAsync("Data/userLogs.json");
                await _context.UserLogs.AddRangeAsync(logs);
                await _context.SaveChangesAsync();
            }
        }
    }
}
