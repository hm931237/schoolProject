using AutoMapper;
using School.Application.DTOs;
using School.Domain.Entities;

namespace School.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}
