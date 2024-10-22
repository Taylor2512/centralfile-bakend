using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Request
{
    public sealed record CreateCompanyRequest : IRequest<CompanyDto>
    {
        public required string Name { get; set; }
        public required string TaxId { get; set; }
        public required string IdentificationType { get; set; }
    }
}
