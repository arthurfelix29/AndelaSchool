namespace AndelaSchool.Application.Dtos
{
    public class CourseDto
    {
        public string Name { get; private set; }

        internal CourseDto() { }

        public CourseDto(string name)
        {
            Name = name;
        }
    }
}