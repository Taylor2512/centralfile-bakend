using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;

using MediatR;

using Microsoft.AspNetCore.Mvc;
namespace CentalFile.managment.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll([FromQuery] GetUserAllRequest request)
        {
            IEnumerable<UserDto> users = await mediator.Send(request);
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById([FromRoute] UserId id)
        {
            GetUserByIdRequest request = new() { Id = id };
            UserDto user = await mediator.Send(request);
            return user != null ? Ok(user) : NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateUserRequest request)
        {
            UserDto userId = await mediator.Send(request);
            return CreatedAtAction(nameof(GetById), new { id = userId }, userId);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update([FromRoute] UserId id, [FromBody] UpdateUserRequest request)
        {
            request.SetUserId(id);
            UserDto response = await mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] UserId id)
        {
            await mediator.Send(new DeleteUserRequest { Id = id });
            return NoContent();
        }
    }
}
