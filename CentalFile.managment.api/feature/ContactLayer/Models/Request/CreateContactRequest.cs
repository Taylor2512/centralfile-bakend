using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Request
{
    public sealed record CreateContactRequest : IRequest<ContactDto>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string MobileNumber { get; set; }
        public required string PhotoUrl { get; set; }
        public UserId? UserId { get; set; }
    }
}
