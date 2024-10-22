using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

namespace CentalFile.managment.api.DtaAcces.Models
{
    public class Contact
    {
        public required ContactId Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string MobileNumber { get; set; }
        public required string PhotoUrl { get; set; }
        public UserId? UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public ICollection<Company> Companies { get; set; } = [];
        public ICollection<ApplicationUser> SharedWithUsers { get; set; } = [];

    }
}
