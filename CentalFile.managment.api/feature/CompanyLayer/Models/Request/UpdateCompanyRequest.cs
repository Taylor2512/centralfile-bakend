using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Request
{
    public sealed record UpdateCompanyRequest : IRequest<CompanyDto>
    {
        public CompanyId? Id { get; private set; }
        public required string Name { get; set; }
        public required string TaxId { get; set; }
        public required string IdentificationType { get; set; }
        public void SetCompanyId(CompanyId id)
        {
            Id = id;
        }
    }
}
