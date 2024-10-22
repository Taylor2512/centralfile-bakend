using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Models.Request
{
    public sealed record UpdateUserRequest : IRequest<UserDto>
    {
        public UserId? Id { get; private set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public CompanyId? CompanyId { get; set; }
        public ContactDto? Company { get; set; }
        public bool RememberMe { get; set; }
        public void SetUserId(UserId id)
        {
            Id = id;
        }
    }
}
