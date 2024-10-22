using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Dtos
{
    public class CompanyDto
    {
        public required CompanyId Id { get; set; }
        public required string Name { get; set; }
        public required string TaxId { get; set; }
        public required string IdentificationType { get; set; }
    }
}
