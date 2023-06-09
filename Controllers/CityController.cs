using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        public CityController(ILogger<CityController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "City")]
        public City city()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetCityAsync().Result;
        }
    }
}
