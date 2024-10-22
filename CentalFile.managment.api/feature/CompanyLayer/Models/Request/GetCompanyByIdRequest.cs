using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Request
{
    public sealed record GetCompanyByIdRequest : IRequest<CompanyDto>
    {
        public required CompanyId Id { get; set; }
    }
}
