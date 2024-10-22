using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Request
{
    public sealed record UpdateContactRequest : IRequest<ContactDto>
    {
        public ContactId? Id { get; private set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string MobileNumber { get; set; }
        public required string PhotoUrl { get; set; }
        public UserId? UserId { get; set; }
        public void SetContactId(ContactId id)
        {
            Id = id;
        }
    }
}
