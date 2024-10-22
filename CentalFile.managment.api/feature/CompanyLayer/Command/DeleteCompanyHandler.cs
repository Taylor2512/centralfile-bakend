using CentalFile.managment.api.feature.CompanyLayer.Exceptions;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Command
{
    public class DeleteCompanyHandler(ICommandCompanyRepository companyRepository, IQueryCompanyRepository queryCompanyRepository) : IRequestHandler<DeleteCompanyRequest>
    {
        public async Task Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
        {
            DtaAcces.Models.Company company = await queryCompanyRepository.GetByIdAsync(request.Id) ?? throw new CompanyNotFoundException($"Company with ID {request.Id} not found.");
            companyRepository.Remove(company);
            await companyRepository.SaveChangesAsync();
        }
    }
}
