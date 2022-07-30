using AndelaSchool.Domain.Core.Models;

namespace AndelaSchool.Domain.Models
{
    public class Student : Entity
    {
        public string Name { get; private set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        private Student() => Enrollments = new HashSet<Enrollment>();

        public static Student Create(Guid id, string name)
        {
            return new()
            {
                Id = id,
                Name = name
            };
        }
    }
}