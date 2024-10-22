using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Request
{
    public sealed record GetContactByIdRequest : IRequest<ContactDto>
    {
        public ContactId Id { get; set; }
    }
}
