namespace AndelaSchool.Application.Dtos
{
    public class StudentDto
    {
        public string Name { get; private set; }
        public ICollection<CourseDto> Courses { get; set; }

        internal StudentDto() { }

        public StudentDto(string name, ICollection<CourseDto> courses)
        {
            Name = name;
            Courses = courses;
        }
    }
}