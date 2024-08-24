using Microsoft.AspNetCore.Mvc;
using SIMGate.Domain;

namespace SIMGate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SIMCardController : ControllerBase
    {
        [HttpPost]
        public ActionResult AuthenticateSIMCard(int pin)
        {
            return Ok();
        }
    }
}
