using System;

namespace SwaggerSample
{
    public class WeatherForecast
    {
        /// <summary>
        /// Date of Weather
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Temperture in celsius 
        /// </summary>
        public int? TemperatureC { get; set; }

        /// <summary>
        /// Temperature in fahrenheit
        /// </summary>
        public int? TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Temperture Summery of the Day 
        /// </summary>
        public string Summary { get; set; }
    }
}
