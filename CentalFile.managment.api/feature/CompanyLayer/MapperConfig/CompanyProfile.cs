using AutoMapper;

using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.CompanyLayer.Models.Dtos;
using CentalFile.managment.api.feature.CompanyLayer.Models.Request;

namespace CentalFile.managment.api.feature.CompanyLayer.MapperConfig
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<CreateCompanyRequest, CompanyDto>().ReverseMap();
            CreateMap<UpdateCompanyRequest, CompanyDto>().ReverseMap();
            CreateMap<CreateCompanyRequest, Company>().ReverseMap();
            CreateMap<UpdateCompanyRequest, Company>().ReverseMap();
        }
    }
}
