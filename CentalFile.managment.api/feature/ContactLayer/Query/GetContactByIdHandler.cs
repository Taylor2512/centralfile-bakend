using AutoMapper;

using CentalFile.managment.api.feature.ContactLayer.Repository.Query.Interfaz;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Exceptions;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Query
{
    public class GetContactByIdHandler(IQueryContactRepository queryContactRepository, IMapper mapper) : IRequestHandler<GetContactByIdRequest, ContactDto>
    {
        public async Task<ContactDto> Handle(GetContactByIdRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Contact? Contact = await queryContactRepository.GetByIdAsync(request.Id);
            return Contact == null ? throw new UserNotFoundException($"User with ID {request.Id} not found.") : mapper.Map<ContactDto>(Contact);
        }
    }
}
