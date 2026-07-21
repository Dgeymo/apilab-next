using Microsoft.AspNetCore.Mvc;

namespace ApiLabNext.Api.Controllers
{
    [ApiController]
    [Route("api/testing")]
    public class TestingController : ControllerBase
    {
        [HttpGet("run-all")]
        public IActionResult RunAll()
        {
            return Ok("Running all endpoints...");
        }
    }
}