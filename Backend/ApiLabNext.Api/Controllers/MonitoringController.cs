using ApiLabNext.Aplication.DTOs;
using ApiLabNext.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiLabNext.Aplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoringController(IGetByPage<LogsPageDTO> _logs) : ControllerBase
    {
        [HttpGet("logs")]
        public async Task<ActionResult> GetLogs([FromQuery] int page, [FromQuery] int pageSize)
        {
            return Ok(await _logs.ExecuteAsync(page, pageSize));
        }
    }
}
