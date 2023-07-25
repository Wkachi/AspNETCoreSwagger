using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ASPNETCoreExample
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCustomers")]

        
            public IEnumerable<WeatherForecast> Get()
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    //Date = DateTime.Now.AddDays(index),
                    //TemperatureC = Random.Shared.Next(-20, 55),
                    //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }

        }
    
}
