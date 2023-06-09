using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueryController : ControllerBase
    {
        private readonly ILogger<QueryController> _logger;
        public QueryController(ILogger<QueryController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "Query")]
        public Query query()
        {
            IPClient iPClient = new IPClient();
            return iPClient.GetQueryAsync().Result;
        }
    }
}
