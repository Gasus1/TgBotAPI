using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetUserDataController : ControllerBase
    {
        private readonly ILogger<GetUserDataController> _logger;
        public GetUserDataController(ILogger<GetUserDataController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetUserData")]
        public IP_Data UserData()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetUserDataAsync().Result;
        }
    }
}
