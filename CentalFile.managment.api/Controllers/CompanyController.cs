using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace CentalFile.managment.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController(IMediator mediator) : ControllerBase
    {
        [ProducesResponseType<IEnumerable<CompanyDto>>((int)HttpStatusCode.OK)]

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetAll([FromQuery] GetCompanyAllRequest request)
        {
            IEnumerable<CompanyDto> companies = await mediator.Send(request);
            return Ok(companies);
        }
        [ProducesResponseType<CompanyDto>((int)HttpStatusCode.OK)]

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDto>> GetById([FromRoute] CompanyId id)
        {
            GetCompanyByIdRequest request = new() { Id = id };
            CompanyDto company = await mediator.Send(request);
            return Ok(company);
        }
        [ProducesResponseType<CompanyDto>((int)HttpStatusCode.Created)]
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateCompanyRequest request)
        {
            CompanyDto companyId = await mediator.Send(request);
            return CreatedAtAction(nameof(GetById), new { id = companyId }, companyId);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CompanyDto>> Update([FromRoute] CompanyId id, [FromBody] UpdateCompanyRequest request)
        {
            request.SetCompanyId(id);
            CompanyDto response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] CompanyId id)
        {
            await mediator.Send(new DeleteCompanyRequest { Id = id });
            return NoContent();
        }
    }
}
