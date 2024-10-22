using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;

namespace CentalFile.managment.api.feature.UserLayer.Models.Dtos
{
    public sealed record UserDto
    {
        public UserId? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public CompanyId? CompanyId { get; set; }
        public ContactDto? Company { get; set; }
        public ICollection<ContactDto> Contacts { get; set; } = new List<ContactDto>();
        public bool RememberMe { get; set; }
    }
}
