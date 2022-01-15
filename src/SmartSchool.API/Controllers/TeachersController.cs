using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    public class TeachersController : BaseController
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAllTeachers()
        {
            return Ok();
        }

        [HttpGet("{teacherId:guid}")]
        public async Task<IActionResult> GetTeacherById([FromRoute] Guid teacherId)
        {
            return Ok();
        }
    }
}
