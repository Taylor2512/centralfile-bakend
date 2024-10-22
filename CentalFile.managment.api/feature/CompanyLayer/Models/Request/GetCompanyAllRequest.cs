using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;

using MediatR;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Request
{
    public sealed record GetCompanyAllRequest : IRequest<IEnumerable<CompanyDto>>
    {
        public string? Search { get; set; }
    }
}
