using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Request
{
    public sealed record GetContactAllRequest : IRequest<IEnumerable<ContactDto>>
    {
        public string? Search { get; set; }
    }
}
