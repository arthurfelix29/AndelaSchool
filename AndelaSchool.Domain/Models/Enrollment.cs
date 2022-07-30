using AndelaSchool.Domain.Core.Models;

namespace AndelaSchool.Domain.Models
{
    public class Enrollment : Entity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        private Enrollment() { }

        public static Enrollment Create(Guid id, Guid studentId, Guid courseId)
        {
            return new()
            {
                Id = id,
                StudentId = studentId,
                CourseId = courseId
            };
        }
    }
}