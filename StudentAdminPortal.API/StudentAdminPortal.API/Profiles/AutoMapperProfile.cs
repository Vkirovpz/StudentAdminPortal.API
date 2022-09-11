using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Profiles.AfterMaps;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, GetStudentDto>().ReverseMap();
            CreateMap<Gender, GetGenderDto>().ReverseMap();
            CreateMap<Address, GetAddressDto>().ReverseMap();

            CreateMap<UpdateStudentRequest, Student>()
                .AfterMap<UpdateStudentRequestAfterMap>();
                
        }

    }
}
