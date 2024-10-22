using CentalFile.managment.api.feature.UserLayer.Exceptions;
using CentalFile.managment.api.feature.UserLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.UserLayer.Command
{
    public class DeleteUserHandler(ICommandUserRepository userRepository, IQueryUserRepository queryuserRepository) : IRequestHandler<DeleteUserRequest>
    {
        public async Task Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.ApplicationUser? user = await queryuserRepository.GetByIdAsync(request.Id);
            if (user == null)
            {
                throw new UserNotFoundException($"User with ID {request.Id} not found.");
            }

            userRepository.Remove(user);
            await userRepository.SaveChangesAsync();
        }
    }
}
