using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Request
{
    public sealed record DeleteContactRequest : IRequest
    {
        public int Id { get; set; }
    }
}
