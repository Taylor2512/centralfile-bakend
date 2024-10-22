using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Models.Request
{
    public sealed record DeleteUserRequest : IRequest
    {
        public UserId? Id { get; set; }
    }
}
