using AutoMapper;

using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Query
{
    public class GetCompanyAllHandler(IQueryCompanyRepository queryCompanyRepository, IMapper mapper) : IRequestHandler<GetCompanyAllRequest, IEnumerable<CompanyDto>>
    {
        public async Task<IEnumerable<CompanyDto>> Handle(GetCompanyAllRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<DtaAcces.Models.Company> companies = await queryCompanyRepository.GetAllAsync();
            return mapper.Map<IEnumerable<CompanyDto>>(companies);
        }
    }
}
