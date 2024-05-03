using Microsoft.AspNetCore.Mvc;

namespace Canteen.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public AdminController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        
    }
}
