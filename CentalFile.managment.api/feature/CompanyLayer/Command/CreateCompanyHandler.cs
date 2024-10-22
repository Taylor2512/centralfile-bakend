using AutoMapper;

using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Command.Interfaces;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Command
{
    public class CreateCompanyHandler(ICommandCompanyRepository companyRepository, IMapper mapper) : IRequestHandler<CreateCompanyRequest, CompanyDto>
    {
        public async Task<CompanyDto> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
        {
            Company company = mapper.Map<Company>(request);
            companyRepository.Add(company);
            await companyRepository.SaveChangesAsync();
            return mapper.Map<CompanyDto>(company);
        }
    }
}
