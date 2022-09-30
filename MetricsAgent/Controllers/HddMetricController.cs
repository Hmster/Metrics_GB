﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/hdd")]
    [ApiController]
    public class HddMetricController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetHddMetrics([FromRoute] TimeSpan fromTIme, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
