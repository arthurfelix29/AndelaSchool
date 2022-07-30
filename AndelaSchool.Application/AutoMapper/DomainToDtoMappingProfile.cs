using AndelaSchool.Application.Dtos;
using AndelaSchool.Domain.Models;
using AutoMapper;

namespace AndelaSchool.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Student, StudentDto>()
                .ForMember(dto => dto.Courses, opt => opt.MapFrom(student => student.Enrollments.Select(enrollment => enrollment.Course).ToList()));

            CreateMap<Course, CourseDto>();
        }
    }
}