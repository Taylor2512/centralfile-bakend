using AutoMapper;

using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.ContactLayer.Models.Dtos;
using CentalFile.managment.api.feature.ContactLayer.Models.Request;

namespace CentalFile.managment.api.feature.ContactLayer.MapperConfig
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<CreateContactRequest, ContactDto>().ReverseMap();
            CreateMap<UpdateContactRequest, ContactDto>().ReverseMap();
            CreateMap<CreateContactRequest, Contact>().ReverseMap();
            CreateMap<UpdateContactRequest, Contact>().ReverseMap();
        }
    }
}
