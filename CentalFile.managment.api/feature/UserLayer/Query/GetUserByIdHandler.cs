using AutoMapper;

using CentalFile.managment.api.feature.UserLayer.Exceptions;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Query
{
    public class GetUserByIdHandler(IQueryUserRepository queryUserRepository, IMapper mapper) : IRequestHandler<GetUserByIdRequest, UserDto>
    {
        public async Task<UserDto> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.User? user = await queryUserRepository.GetByIdAsync(request.Id);
            return user == null ? throw new UserNotFoundException($"User with ID {request.Id} not found.") : mapper.Map<UserDto>(user);
        }
    }
}
