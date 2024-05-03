using Microsoft.AspNetCore.Mvc;

namespace Canteen.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public LoginController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        
    }
}
