using AutoMapper;

using CentalFile.managment.api.feature.ContactLayer.Exceptions;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;
using CentalFile.managment.api.feature.ContactLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.ContactLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Command
{
    public class UpdateContactHandler(ICommandContactRepository contactRepository, IQueryContactRepository queryContactRepository, IMapper mapper) : IRequestHandler<UpdateContactRequest, ContactDto>
    {
        public async Task<ContactDto> Handle(UpdateContactRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Contact? existingContact = await queryContactRepository.GetByIdAsync(request.Id);
            if (existingContact == null)
            {
                throw new ContactNotFoundException($"Contact with ID {request.Id} not found.");
            }

            mapper.Map(request, existingContact);
            contactRepository.Update(existingContact);
            await contactRepository.SaveChangesAsync();

            return mapper.Map<ContactDto>(existingContact);
        }
    }
}
