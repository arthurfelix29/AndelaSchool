using AndelaSchool.Application.Dtos;

namespace AndelaSchool.Application.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllAsync();
    }
}