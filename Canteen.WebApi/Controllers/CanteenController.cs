using Microsoft.AspNetCore.Mvc;

namespace Canteen.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CanteenController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public CanteenController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

            }
}
