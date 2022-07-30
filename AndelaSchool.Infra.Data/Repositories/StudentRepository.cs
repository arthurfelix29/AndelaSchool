using AndelaSchool.Domain.Interfaces;
using AndelaSchool.Domain.Models;
using AndelaSchool.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AndelaSchool.Infra.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AndelaSchoolContext context) : base(context) { }

        public async Task<IEnumerable<Student>> GetAllSortedByCreationDateAsync()
            => await _dbSet
                        .Include(student => student.Enrollments).ThenInclude(enrollment => enrollment.Course)
                        .OrderByDescending(student => student.CreatedAt)
                        .ToListAsync();
    }
}