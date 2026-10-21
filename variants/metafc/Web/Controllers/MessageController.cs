using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EstaWebSeAutodestruira.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly ILogger<MessageController> _logger;
        private readonly MessageService _service;

        public MessageController(ILogger<MessageController> logger, MessageService service )
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = _service.GetRandom();
            var span = _service.LastUpdate.AddDays(1) - DateTime.UtcNow;
            result.SecondsUntilDestruction = (int) span.TotalSeconds;
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Post([FromBody] string message)
        {
            var encondedMessage = HttpUtility.HtmlEncode(message);
            _service.Add(encondedMessage);
            return Ok();
        }
    }
}
