using Microsoft.AspNetCore.Mvc;

namespace AndelaSchool.Services.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}")]
    public abstract class ApiController : ControllerBase
    { }
}