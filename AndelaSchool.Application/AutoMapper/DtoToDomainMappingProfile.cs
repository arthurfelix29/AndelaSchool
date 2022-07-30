using AndelaSchool.Application.Dtos;
using AndelaSchool.Domain.Models;
using AutoMapper;

namespace AndelaSchool.Application.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<StudentDto, Student>();
            CreateMap<CourseDto, Course>();
        }
    }
}