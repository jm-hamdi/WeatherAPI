using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWeather()
        {
            var weatherData = new[]
            {
                new { Date = "2024-09-19", TemperatureC = 25, Summary = "Sunny" },
                new { Date = "2024-09-20", TemperatureC = 22, Summary = "Cloudy" },
            };

            return Ok(weatherData);
        }
    }
}
