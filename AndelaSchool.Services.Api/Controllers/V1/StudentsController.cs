using AndelaSchool.Application.Dtos;
using AndelaSchool.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AndelaSchool.Services.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class StudentsController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService) => _studentService = studentService;


        [SwaggerOperation(Summary = "Shows a list of all students and courses they are currently enrolled in")]
        [HttpGet("students", Name = nameof(GetAllAsync))]
        public async Task<IEnumerable<StudentDto>> GetAllAsync() => await _studentService.GetAllAsync();
    }
}