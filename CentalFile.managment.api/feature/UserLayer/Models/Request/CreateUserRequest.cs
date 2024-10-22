using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Models.Request
{
    public sealed record CreateUserRequest : IRequest<UserDto>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
