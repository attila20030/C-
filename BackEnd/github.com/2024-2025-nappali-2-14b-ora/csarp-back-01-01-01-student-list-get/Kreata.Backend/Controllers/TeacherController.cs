using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepo _techerRepo;

        public TeacherController(ITeacherRepo teacherRepo)
        {
            _techerRepo = teacherRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllTeacherAsync()
        {
            List<Teacher>? teachers = new();
            if (_techerRepo is not null)
            {
                teachers = await _techerRepo.GetAll();
                return Ok(teachers);
            }
            return BadRequest("Tanár adatok elérhetetlenek!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Teacher? teacher = new();
            if (_techerRepo is not null)
            {
                teacher = await _techerRepo.GetBy(id);
                if (teacher is not null)
                    return Ok(teacher);
            }
            return BadRequest("Tanár adatok elérhetetlenek");

        }
    }
}
