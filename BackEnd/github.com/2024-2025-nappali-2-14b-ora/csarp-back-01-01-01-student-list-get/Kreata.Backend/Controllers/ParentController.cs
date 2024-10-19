using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController(ITeacherRepo parentRepo) : ControllerBase
    {
        private readonly IParentRepo _ParentRepo = (IParentRepo?)parentRepo;

        [HttpGet]
        public async Task<IActionResult> SelectAllParentAsync()
        {
            List<Parent>? Parents = new();
            if (_ParentRepo is not null)
            {
                Parents = await _ParentRepo.GetAll();
                return Ok(Parents);
            }
            return BadRequest("A szülő adatai elérhetetlenek!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Parent? szulo = new();
            if (_ParentRepo is not null)
            {
                szulo = await _ParentRepo.GetBy(id);
                if (szulo is not null)
                    return Ok(szulo);
            }
            return BadRequest("A szülő adatai elérhetetlenek!");

        }
    }
}
