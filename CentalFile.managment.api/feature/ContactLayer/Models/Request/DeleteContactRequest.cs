using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Request
{
    public sealed record DeleteContactRequest : IRequest
    {
        public ContactId Id { get; set; }
    }
}
