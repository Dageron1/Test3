using Microsoft.EntityFrameworkCore;
using Test3.Data;
using Test3.DTOs;
using Test3.Interfaces;

namespace Test3.Services;

public class UserService : IUserService
{
    private readonly UserLogsDbContext _context;

    public UserService(UserLogsDbContext context)
    {
        _context = context;
    }

    public async Task<PagedUsersResponseDto> GetUsersAsync(int page, int pageSize)
    {
        var users = await _context.Users
            .OrderBy(u => u.FirstName)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(u => new UserResponseDto(
                u.Id,
                u.FirstName,
                $"{u.MailingAddress.Address1}, {u.MailingAddress.Zipcode}"
            ))
            .ToListAsync();

        return new PagedUsersResponseDto(users);
    }
}
