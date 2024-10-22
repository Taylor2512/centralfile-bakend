using AutoMapper;

using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Query
{
    public class GetUserAllHandler(IQueryUserRepository queryUserRepository, IMapper mapper) : IRequestHandler<GetUserAllRequest, IEnumerable<UserDto>>
    {
        public async Task<IEnumerable<UserDto>> Handle(GetUserAllRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<DtaAcces.Models.ApplicationUser> users = await queryUserRepository.GetAllAsync();
            return mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
