using API_IPBot2.Clients;
using API_IPBot2.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Replication.PgOutput.Messages;
using System.Globalization;

namespace API_IPBot2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IPController : ControllerBase
    {
       private readonly ILogger<IPController> _logger;
        public IPController(ILogger<IPController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "IPData")]
        public IP_Data Data(string query)
        {
            Database db = new Database();
            IPClient iPClient = new IPClient();
            return iPClient.GetDataAsync(query).Result;
        }
    }  
}
