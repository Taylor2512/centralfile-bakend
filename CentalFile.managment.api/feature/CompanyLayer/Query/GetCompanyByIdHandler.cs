using AutoMapper;

using CentalFile.managment.api.feature.CompanyLayer.Exceptions;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Query
{
    public class GetCompanyByIdHandler(IQueryCompanyRepository queryCompanyRepository, IMapper mapper)
        : IRequestHandler<GetCompanyByIdRequest, CompanyDto>
    {
        public async Task<CompanyDto> Handle(GetCompanyByIdRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Company company = await queryCompanyRepository.GetByIdAsync(request.Id) ?? throw new CompanyNotFoundException($"Company with ID {request.Id} not found.");
            return mapper.Map<CompanyDto>(company);
        }
    }
}
