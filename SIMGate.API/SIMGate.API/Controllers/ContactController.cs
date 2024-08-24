using Microsoft.AspNetCore.Mvc;
using SIMGate.Domain;

namespace SIMGate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Contact>> GetAllContacts()
        {
            return Ok();
        }
    }
}
