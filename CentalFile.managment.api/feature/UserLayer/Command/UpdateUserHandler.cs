using AutoMapper;

using CentalFile.managment.api.feature.UserLayer.Exceptions;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Command
{
    public class UpdateUserHandler(ICommandUserRepository userRepository, IQueryUserRepository queryUserRepository,
        IMapper mapper) : IRequestHandler<UpdateUserRequest, UserDto>
    {


        public async Task<UserDto> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.ApplicationUser? existingUser = await queryUserRepository.GetByIdAsync(request.Id);
            if (existingUser == null)
            {
                throw new UserNotFoundException($"User with ID {request.Id} not found.");
            }

            mapper.Map(request, existingUser);
            userRepository.Update(existingUser);
            await userRepository.SaveChangesAsync();

            return mapper.Map<UserDto>(existingUser);
        }
    }
}
