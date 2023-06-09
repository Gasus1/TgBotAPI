using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly ILogger<RegionController> _logger;
        public RegionController(ILogger<RegionController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "Region")]
        public RegionName region()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetRegionAsync().Result;
        }
    }
}
