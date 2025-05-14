using Microsoft.AspNetCore.Mvc;
using Test3.DTOs;
using Test3.Interfaces;

namespace Test3.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserLogsController : ControllerBase
{
    private readonly IUserLogService _logService;

    public UserLogsController(IUserLogService logService)
    {
        _logService = logService;
    }

    [HttpGet("summary")]
    public async Task<ActionResult<UserLogSummaryResponse>> GetTopUsers()
    {
        var result = await _logService.GetTopUsersAsync();
        return Ok(result);
    }
}
