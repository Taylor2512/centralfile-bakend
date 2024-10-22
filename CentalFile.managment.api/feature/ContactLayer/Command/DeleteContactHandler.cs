using CentalFile.managment.api.feature.ContactLayer.Exceptions;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;
using CentalFile.managment.api.feature.ContactLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.ContactLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Command
{
    public class DeleteContactHandler(ICommandContactRepository contactRepository, IQueryContactRepository querycontactRepository) : IRequestHandler<DeleteContactRequest>
    {
        public async Task Handle(DeleteContactRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Contact? contact = await querycontactRepository.GetByIdAsync(request.Id);
            if (contact == null)
            {
                throw new ContactNotFoundException($"Contact with ID {request.Id} not found.");
            }

            contactRepository.Remove(contact);
            await contactRepository.SaveChangesAsync();
        }
    }
}
