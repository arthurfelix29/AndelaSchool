using AndelaSchool.Application.Dtos;
using AndelaSchool.Application.Services.Interfaces;
using AndelaSchool.Domain.Interfaces;
using AutoMapper;

namespace AndelaSchool.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public StudentService(IMapper mapper, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<StudentDto>> GetAllAsync() => _mapper.Map<IEnumerable<StudentDto>>(await _studentRepository.GetAllSortedByCreationDateAsync());
    }
}