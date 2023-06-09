using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrgsController : ControllerBase
    {
        private readonly ILogger<OrgsController> _logger;
        public OrgsController(ILogger<OrgsController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "Orgs")]
        public Orgs orgs()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetOrgsAsync().Result;
        }
    }
}
