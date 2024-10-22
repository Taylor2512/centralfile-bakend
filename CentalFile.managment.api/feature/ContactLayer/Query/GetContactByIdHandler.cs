using AutoMapper;

using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;
using CentalFile.managment.api.feature.UserLayer.Exceptions;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Query
{
    public class GetContactByIdHandler(IQueryCompanyRepository querycompanyRepository, IMapper mapper) : IRequestHandler<GetContactByIdRequest, ContactDto>
    {
        public async Task<ContactDto> Handle(GetContactByIdRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Company? company = await querycompanyRepository.GetByIdAsync(request.Id);
            return company == null ? throw new UserNotFoundException($"User with ID {request.Id} not found.") : mapper.Map<ContactDto>(company);
        }
    }
}
