using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViewController : ControllerBase
    {
        private readonly ILogger<ViewController> _logger;

        public ViewController(ILogger<ViewController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return Team.players.ToArray();
        }
    }
}
