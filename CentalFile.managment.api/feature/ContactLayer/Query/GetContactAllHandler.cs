using AutoMapper;

using CentalFile.managment.api.feature.ContactLayer.Repository.Query.Interfaz;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;

using MediatR;

namespace CentalFile.managment.api.feature.ContactLayer.Query
{
    public class GetContactAllHandler(IQueryContactRepository queryContactRepository, IMapper mapper) : IRequestHandler<GetContactAllRequest, IEnumerable<ContactDto>>
    {
        public async Task<IEnumerable<ContactDto>> Handle(GetContactAllRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<DtaAcces.Models.Contact> contacts = await queryContactRepository.GetAllAsync();
            return mapper.Map<IEnumerable<ContactDto>>(contacts);
        }
    }
}
