using Microsoft.EntityFrameworkCore;
using Test3.Data;
using Test3.DTOs;
using Test3.Interfaces;

namespace Test3.Services;

public class UserLogService : IUserLogService
{
    private readonly UserLogsDbContext _context;

    public UserLogService(UserLogsDbContext context)
    {
        _context = context;
    }

    public async Task<UserLogSummaryResponse> GetTopUsersAsync(int top = 3)
    {
        var joined = await _context.UserLogs
            .Join(_context.Users,
                log => log.UserId,
                user => user.Id,
                (log, user) => new { user.FirstName })
            .ToListAsync();

        var summary = joined
            .GroupBy(x => x.FirstName)
            .Select(g => new UserLogSummaryDto(g.Key, g.Count()))
            .OrderByDescending(x => x.LogsAmount)
            .Take(top)
            .ToList();

        return new UserLogSummaryResponse(summary);
    }
}
