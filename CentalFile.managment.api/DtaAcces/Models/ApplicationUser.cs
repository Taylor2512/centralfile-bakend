using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.AspNetCore.Identity;

namespace CentalFile.managment.api.DtaAcces.Models
{
    public class ApplicationUser : IdentityUser<UserId>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public CompanyId? CompanyId { get; set; }
        public Company? Company { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public bool RememberMe { get; set; }
    }
}
