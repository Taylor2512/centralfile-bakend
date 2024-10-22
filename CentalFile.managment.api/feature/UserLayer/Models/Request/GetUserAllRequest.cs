using CentalFile.managment.api.feature.UserLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Models.Request
{
    public sealed record GetUserAllRequest : IRequest<IEnumerable<UserDto>>
    {
        public string? Search { get; set; }
    }
}
