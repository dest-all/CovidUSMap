using CovidUsMap.Models;
using CovidUsMap.Services;
using Microsoft.AspNetCore.Mvc;

namespace CovidTestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsController : ControllerBase
    {
        readonly ILogger<MetricsController> _logger;
        readonly CovidMetricsRetriever _metricsRetriever;

        public MetricsController(ILogger<MetricsController> logger, CovidMetricsRetriever metricsRetriever)
        {
            _logger = logger;
            _metricsRetriever = metricsRetriever;
        }

        [HttpGet]
        public async Task<Dictionary<string, CovidLevels>> GetAsync()
        {
            var metrics = await _metricsRetriever.GetAsync();

            var result = metrics.ToDictionary(m => m.State, m => new CovidLevels
            {
                CasesDensity = (byte)m.RiskLevels.CaseDensity,
                Infection = (byte)m.RiskLevels.InfectionRate,
                OverallRisk = (byte)m.RiskLevels.Overall,
                TestPositivity = (byte)m.RiskLevels.TestPositivityRatio
            });

            return result;
        }
    }
}