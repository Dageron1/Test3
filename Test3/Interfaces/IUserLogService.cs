using Test3.DTOs;

namespace Test3.Interfaces;

public interface IUserLogService
{
    Task<UserLogSummaryResponse> GetTopUsersAsync(int top = 3);
}