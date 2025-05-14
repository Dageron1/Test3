using Microsoft.AspNetCore.Mvc;
using Test3.Interfaces;

namespace Test3.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SystemLogsController : ControllerBase
{
    private readonly ISystemUserLogsCollection _logsCollection;

    public SystemLogsController(ISystemUserLogsCollection logsCollection)
    {
        _logsCollection = logsCollection;
    }

    [HttpGet]
    public ActionResult<object> GetLogs()
    {
        return Ok(new { logs = _logsCollection.Logs });
    }
}
