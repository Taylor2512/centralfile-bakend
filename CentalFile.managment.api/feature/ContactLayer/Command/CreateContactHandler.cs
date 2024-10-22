using AutoMapper;

using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;
using CentalFile.managment.api.feature.ContactLayer.Repository.Command.Interfaces;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Command
{
    public class CreateContactHandler(ICommandContactRepository contactRepository, IMapper mapper) : IRequestHandler<CreateContactRequest, ContactDto>
    {
        public async Task<ContactDto> Handle(CreateContactRequest request, CancellationToken cancellationToken)
        {
            Contact contact = mapper.Map<Contact>(request);
            contactRepository.Add(contact);
            await contactRepository.SaveChangesAsync();
            return mapper.Map<ContactDto>(contact);
        }
    }
}
