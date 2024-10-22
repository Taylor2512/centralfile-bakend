using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Models.Request
{
    public sealed record CreateUserRequest : IRequest<UserDto>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public CompanyId? CompanyId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
    }
}
