using API_IPBot2.Clients;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoundIPController : ControllerBase
    {
        private readonly ILogger<FoundIPController> _logger;
        public FoundIPController(ILogger<FoundIPController> logger)
        {
            _logger = logger;
        }
        [HttpPost(Name = "FoundIPData")]
        public void FondIPData(string query)
        {
            Database db = new Database();
            IPClient iPClient = new IPClient();
            db.InsertIpDataAsync(iPClient.GetDataAsync(query).Result);
        }
    }
}
