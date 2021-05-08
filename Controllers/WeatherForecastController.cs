using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SwaggerSample.Controllers
{

    /// <summary>
    /// This is Wheather Forcasting Controller
    /// </summary>
    /// 
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        

        public WeatherForecastController()
        {

        }

        /// <summary>
        /// This Method returns Wheather types
        /// </summary>
        /// <returns>It returns array of Weather </returns>
        [HttpGet("/getWeather")]
        public IEnumerable<WeatherForecast> GetWeather()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// This Method Add New Temperature for Day
        /// </summary>
        /// <param name="weatherForecast"> This is new Wheather Forcast class for adding</param>
        /// <returns></returns>
        [HttpPost("/addWeather")]
        public List<WeatherForecast> AddWeather([FromBody] WeatherForecast weatherForecast)
        {
            var rng = new Random();
            weatherForecast.TemperatureC = rng.Next(-19, 56);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray().Append(weatherForecast).ToList();
        }


    }
}
