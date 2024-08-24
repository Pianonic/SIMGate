using Microsoft.AspNetCore.Mvc;
using SIMGate.Domain;

namespace SIMGate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Message>> GetMessages()
        {
            return Ok();
        }
    }
}
