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

        [HttpGet("{date}")]
public IActionResult GetWeatherByDate(string date)
{
    var weatherData = new[]
    {
        new { Date = "2024-09-19", TemperatureC = 25, Summary = "Sunny" },
        new { Date = "2024-09-20", TemperatureC = 22, Summary = "Cloudy" },
    };

    var weatherForDate = weatherData.FirstOrDefault(w => w.Date == date);

    if (weatherForDate == null)
    {
        return NotFound(new { Message = $"No weather data found for {date}." });
    }

    return Ok(weatherForDate);
}

[HttpPost]
public IActionResult AddWeather([FromBody] WeatherData newWeather)
{
    if (newWeather == null)
    {
        return BadRequest(new { Message = "Invalid weather data." });
    }

    // For now, we are just simulating adding the data (you could store it in a database later)
    var createdWeather = new
    {
        Date = newWeather.Date,
        TemperatureC = newWeather.TemperatureC,
        Summary = newWeather.Summary
    };

    return CreatedAtAction(nameof(GetWeatherByDate), new { date = newWeather.Date }, createdWeather);
}

public class WeatherData
{
    public string Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
}


[HttpPut("{date}")]
public IActionResult UpdateWeather(string date, [FromBody] WeatherData updatedWeather)
{
    if (updatedWeather == null || updatedWeather.Date != date)
    {
        return BadRequest(new { Message = "Invalid data." });
    }

    // Logic to update weather data (e.g., lookup in database and modify the record)
    var updatedData = new
    {
        Date = updatedWeather.Date,
        TemperatureC = updatedWeather.TemperatureC,
        Summary = updatedWeather.Summary
    };

    return Ok(updatedData);
}


[HttpDelete("{date}")]
public IActionResult DeleteWeather(string date)
{
    // Simulate deleting the data
    var weatherData = new[]
    {
        new { Date = "2024-09-19", TemperatureC = 25, Summary = "Sunny" },
        new { Date = "2024-09-20", TemperatureC = 22, Summary = "Cloudy" },
    };

    var weatherToDelete = weatherData.FirstOrDefault(w => w.Date == date);

    if (weatherToDelete == null)
    {
        return NotFound(new { Message = $"No weather data found for {date}." });
    }

    // Here, you'd typically delete the data from your database or collection
    return Ok(new { Message = $"Weather data for {date} has been deleted." });
}






    }



    


    
}
