using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace CentalFile.managment.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDto>>> GetAll([FromQuery] GetContactAllRequest request)
        {
            IEnumerable<ContactDto> contacts = await mediator.Send(request);
            return Ok(contacts);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDto>> GetById([FromRoute] ContactId id)
        {
            GetContactByIdRequest request = new() { Id = id };
            ContactDto contact = await mediator.Send(request);
            return contact != null ? Ok(contact) : NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateContactRequest request)
        {
            ContactDto contactId = await mediator.Send(request);
            return CreatedAtAction(nameof(GetById), new { id = contactId }, contactId);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ContactDto>> Update([FromRoute] ContactId id, [FromBody] UpdateContactRequest request)
        {
            request.SetContactId(id);
            ContactDto response = await mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] ContactId id)
        {
            await mediator.Send(new DeleteContactRequest { Id = id });
            return NoContent();
        }
    }
}
