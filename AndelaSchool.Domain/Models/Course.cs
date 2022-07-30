using AndelaSchool.Domain.Core.Models;

namespace AndelaSchool.Domain.Models
{
    public class Course : Entity
    {
        public string Name { get; private set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        private Course() => Enrollments = new HashSet<Enrollment>();

        public static Course Create(Guid id, string name)
        {
            return new()
            {
                Id = id,
                Name = name
            };
        }
    }
}