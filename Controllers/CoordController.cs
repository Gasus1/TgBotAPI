using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoordController : ControllerBase
    {
        private readonly ILogger<CoordController> _logger;
        public CoordController(ILogger<CoordController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "Coord")]
        public Coord coord()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetCoordAsync().Result;
        }
    }
}
