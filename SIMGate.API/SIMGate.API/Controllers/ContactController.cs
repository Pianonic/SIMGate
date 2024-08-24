using MediatR;
using Microsoft.AspNetCore.Mvc;
using SIMGate.Domain;
using SIMGate.Infrastructure.Queries;

namespace SIMGate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetAllContacts()
        {
            await _mediator.Send(new GetContactsQuery());
            return Ok(new List<Contact>());
        }
    }
}
