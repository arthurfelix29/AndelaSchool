using AndelaSchool.Domain.Core.Interfaces;
using AndelaSchool.Domain.Models;

namespace AndelaSchool.Domain.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<IEnumerable<Student>> GetAllSortedByCreationDateAsync();
    }
}