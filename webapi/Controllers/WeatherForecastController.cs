using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    /*private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };*/
    private static readonly string[] Models = new[]
    {
        "GM", "Ford", "Chrysler"
    };
    private static readonly string[] Colors = new[]
   {
        "Red", "White", "Pink"
    };
    private static readonly bool[] StatusValues = new[]
   {
        true, false
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Car> Get(int id)
    {
        return Enumerable.Range(1, 7).Select(index => new Car
        {
            Price = Random.Shared.Next(2000, 55000),
            Model = Models[Random.Shared.Next(Models.Length)],
            MIleage = Random.Shared.Next(20, 550),
            Color = Colors[Random.Shared.Next(Colors.Length)],
            Status = id == 1 ? new Dealer1 { Status = StatusValues[Random.Shared.Next(StatusValues.Length)] }.getStatus : new Dealer2 { Status = StatusValues[Random.Shared.Next(StatusValues.Length)] }.getStatus
        })
        .ToArray();
    }

    /*public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }*/
}
