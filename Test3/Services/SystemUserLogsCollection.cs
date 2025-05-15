using Test3.Data;
using Test3.Interfaces;

namespace Test3.Services;

public class SystemUserLogsCollection : ISystemUserLogsCollection
{
    public List<string> Logs { get; }

    public SystemUserLogsCollection(UserLogsDbContext context)
    {
        // convention-based configuration
        Logs = context.UserLogs
            .Where(log => log.User.FirstName == "SYSTEM USER")
            .Select(log => log.Description)
            .ToList();
    }

    //public SystemUserLogsCollection(UserLogsDbContext context)
    //{
    //    Logs = context.UserLogs
    //        .Join(context.Users,
    //            log => log.UserId,
    //            user => user.Id,
    //            (log, user) => new { user.FirstName, log.Description })
    //        .Where(x => x.FirstName == "SYSTEM USER")
    //        .Select(x => x.Description)
    //        .ToList();
    //}
}
