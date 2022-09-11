using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync ()
        {
            return Ok(await _studentRepository.GetStudentsAsync());
        }

        [HttpGet]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> GetStudentAsync([FromRoute]Guid studentId)
        {
            var student = await _studentRepository.GetStudentAsync(studentId);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPut]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> UpdateStudentAsync([FromRoute] Guid studentId, [FromBody] UpdateStudentRequest request)
        {
            if (await _studentRepository.Exist(studentId))
            {
                _studentRepository
            }
            else
            {
                return NotFound();
            }
        }
    }
}
