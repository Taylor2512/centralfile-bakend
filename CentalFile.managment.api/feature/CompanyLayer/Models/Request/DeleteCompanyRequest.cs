using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Request
{
    public sealed record DeleteCompanyRequest : IRequest
    {
        public required CompanyId Id { get; set; }
    }
}
