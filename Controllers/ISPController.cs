using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ISPController : ControllerBase
    {
        private readonly ILogger<ISPController> _logger;
        public ISPController(ILogger<ISPController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "ISP")]
        public Isp isp()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetIspAsync().Result;
        }
    }
}
