using AutoMapper;

using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.UserLayer.Exceptions;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Command
{
    public class CreateUserHandler(ICommandUserRepository userRepository, IQueryUserRepository queryUserRepository,
        IMapper mapper) :
        IRequestHandler<CreateUserRequest, UserDto>
    {
        public async Task<UserDto> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            try
            {
                IEnumerable<ApplicationUser> existingUser = await queryUserRepository.FindAsync(x => x.Email == request.Email);
                if (existingUser != null)
                {
                    throw new DuplicateUserException($"A user with the email {request.Email} already exists.");
                }
                ApplicationUser user = mapper.Map<ApplicationUser>(request);
                userRepository.Add(user);
                await userRepository.SaveChangesAsync();
                return mapper.Map<UserDto>(user);
            }
            catch (DuplicateUserException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new UserCreationException("An error occurred while creating the user.", ex);
            }
        }
    }
}
