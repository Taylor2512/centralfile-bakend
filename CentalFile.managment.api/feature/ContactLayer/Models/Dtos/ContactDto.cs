using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;

namespace CentalFile.managment.api.feature.ContactLayer.Models.Dtos
{
    public class ContactDto
    {
        public  ContactId? Id { get; set; }
        public  string? FirstName { get; set; }
        public  string? LastName { get; set; }
        public  string? PhoneNumber { get; set; }
        public  string? MobileNumber { get; set; }
        public  string? PhotoUrl { get; set; }
        public UserId? UserId { get; set; }
        public UserDto? User { get; set; }
        public ICollection<CompanyDto>? Companies { get; set; } = [];
        public ICollection<UserDto>? SharedWithUsers { get; set; } = [];
    }
}
