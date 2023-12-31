using EasyTests.Models;
using EasyTests.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyTests.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _forecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService forecastService)
    {
        _logger = logger;
        _forecastService = forecastService;
    }
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherSummary> Get()
    {
        return _forecastService.GetWeatherForecast();
    }

}