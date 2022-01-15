using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : BaseController
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok();
        }

        [HttpGet("{studentId:guid}")]
        public async Task<IActionResult> GetStudentById([FromRoute] Guid studentId)
        {
            return Ok();
        }
    }
}
