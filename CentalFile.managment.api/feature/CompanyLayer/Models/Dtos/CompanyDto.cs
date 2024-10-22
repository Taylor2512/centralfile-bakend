using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

namespace CentalFile.managment.api.feature.CompanyLayer.Models.Dtos
{
    public class CompanyDto
    {
        public  CompanyId? Id { get; set; }
        public  string? Name { get; set; }
        public  string? Identificaction { get; set; }
        public  string? IdentificationType { get; set; }

    }
}
