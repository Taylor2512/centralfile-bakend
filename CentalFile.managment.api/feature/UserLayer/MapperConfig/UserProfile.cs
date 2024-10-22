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
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CreateUserRequest, UserDto>().ReverseMap();
            CreateMap<UpdateUserRequest, UserDto>().ReverseMap();
            CreateMap<CreateUserRequest, User>().ReverseMap();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
        }
    }
}
