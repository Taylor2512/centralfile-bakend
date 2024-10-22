using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Models.Request
{
    public sealed record GetUserByIdRequest : IRequest<UserDto>
    {
        public required UserId Id { get; set; }
    }
}
