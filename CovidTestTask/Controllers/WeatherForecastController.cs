using Microsoft.AspNetCore.Mvc;

namespace CovidTestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsController : ControllerBase
    {
        readonly ILogger<MetricsController> _logger;

        public MetricsController(ILogger<MetricsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<Dictionary<string, byte>> GetAsync()
        {
            
        }
    }
}