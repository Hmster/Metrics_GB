using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet")]
    [ApiController]
    public class DotnetMetricController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetDotnetMetrics([FromRoute] TimeSpan fromTIme, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
