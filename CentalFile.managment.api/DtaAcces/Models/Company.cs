using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

namespace CentalFile.managment.api.DtaAcces.Models
{
    public class Company
    {
        public required CompanyId Id { get; set; }
        public required string Name { get; set; }
        public required string TaxId { get; set; }
        public required string IdentificationType { get; set; }
        public ICollection<ApplicationUser> Users { get; set; } = [];
        public ICollection<Contact> Contacts { get; set; } = [];
    }
}
