using API_IPBot2.Clients;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserIPController : ControllerBase
    {
        private readonly ILogger<UserIPController> _logger;
        public UserIPController(ILogger<UserIPController> logger)
        {
            _logger = logger;
        }
        [HttpPost(Name = "UserData")]
        public void UserData()
        {
            Database db = new Database();
            IPClient iPClient = new IPClient();
            db.InsertUserIpDataAsync(iPClient.GetUserDataAsync().Result);
        }
    }
}
