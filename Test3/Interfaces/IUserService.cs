using Test3.DTOs;

namespace Test3.Interfaces;

public interface IUserService
{
    Task<PagedUsersResponseDto> GetUsersAsync(int page, int pageSize);
}