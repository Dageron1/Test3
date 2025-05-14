using Microsoft.AspNetCore.Mvc;
using Test3.DTOs;
using Test3.Interfaces;

namespace Test3.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<PagedUsersResponseDto>> GetUsers([FromQuery] int page = 1, [FromQuery] int pageSize = 3)
    {
        var users = await _userService.GetUsersAsync(page, pageSize);
        return Ok(users);
    }
}
