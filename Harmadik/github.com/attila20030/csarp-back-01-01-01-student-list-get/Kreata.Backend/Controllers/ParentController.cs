using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : ControllerBase
    {
        private readonly IParentRepo _parentRepo;

        // Constructor to inject the IParentRepo dependency
        public ParentController(IParentRepo parentRepo)
        {
            _parentRepo = parentRepo;
        }

        // GET method to retrieve all parents
        [HttpGet]
        public async Task<IActionResult> SelectAllParentAsync()
        {
            if (_parentRepo is not null)
            {
                var parents = await _parentRepo.GetAll();
                return Ok(parents);
            }
            return BadRequest("A szülő adatai elérhetetlenek!");
        }

        // GET method to retrieve a parent by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            if (_parentRepo is not null)
            {
                var parent = await _parentRepo.GetBy(id);
                if (parent is not null)
                {
                    return Ok(parent);
                }
            }
            return BadRequest("A szülő adatai elérhetetlenek!");
        }
    }
}
