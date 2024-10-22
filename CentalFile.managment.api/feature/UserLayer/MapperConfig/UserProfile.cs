using AutoMapper;

using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.UserLayer.Models.Dtos;
using CentalFile.managment.api.feature.UserLayer.Models.Request;

namespace CentalFile.managment.api.feature.UserLayer.MapperConfig
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserDto>().ReverseMap();
            CreateMap<CreateUserRequest, UserDto>().ReverseMap();
            CreateMap<UpdateUserRequest, UserDto>().ReverseMap();
            CreateMap<CreateUserRequest, ApplicationUser>().ReverseMap();
            CreateMap<UpdateUserRequest, ApplicationUser>().ReverseMap();
        }
    }
}
