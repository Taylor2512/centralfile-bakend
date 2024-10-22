using AutoMapper;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.UserLayer.Exceptions;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;
using Microsoft.AspNetCore.Identity;
using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Command
{
    public class CreateUserHandler(UserManager<User> userManager, IMapper mapper) :
        IRequestHandler<CreateUserRequest, UserDto>
    {
        public async Task<UserDto> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var existingUser = await userManager.FindByEmailAsync(request.Email);
                if (existingUser != null)
                {
                    throw new DuplicateUserException($"A user with the email {request.Email} already exists.");
                }

                var user = new User { UserName = request.Email, Email = request.Email };
                var result = await userManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                {
                    throw new UserCreationException("An error occurred while creating the user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
                }

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