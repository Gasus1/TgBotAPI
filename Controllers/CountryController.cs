using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        public CountryController(ILogger<CountryController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "IPCountry")]
        public IPCountry Country()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetCountryAsync().Result;
        }
    }
}
