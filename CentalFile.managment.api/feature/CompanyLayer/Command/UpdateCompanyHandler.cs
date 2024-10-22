using AutoMapper;

using CentalFile.managment.api.feature.CompanyLayer.Exceptions;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Command
{
    public class UpdateCompanyHandler(ICommandCompanyRepository companyRepository, IQueryCompanyRepository queryCompanyRepository, IMapper mapper) : IRequestHandler<UpdateCompanyRequest, CompanyDto>
    {
        public async Task<CompanyDto> Handle(UpdateCompanyRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Company? existingCompany = await queryCompanyRepository.GetByIdAsync(request.Id);
            if (existingCompany == null)
            {
                throw new CompanyNotFoundException($"Company with ID {request.Id} not found.");
            }

            mapper.Map(request, existingCompany);
            companyRepository.Update(existingCompany);
            await companyRepository.SaveChangesAsync();
            return mapper.Map<CompanyDto>(existingCompany);
        }
    }
}
