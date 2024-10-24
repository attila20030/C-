using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpecialistController : ControllerBase
    {
        private readonly ISpecialistRepo _specialRepo;

        // Constructor to inject the IParentRepo dependency
        public SpecialistController(ISpecialistRepo specialistRepo)
        {
            _specialRepo = specialistRepo;
        }

        // GET method to retrieve all parents
        [HttpGet]
        public async Task<IActionResult> SelectAllPlaceAsync()
        {
            if (_specialRepo is not null)
            {
                var specialist = await _specialRepo.GetAll();
                return Ok(specialist);
            }
            return BadRequest("A szakember adatai elérhetetlenek!");
        }

        // GET method to retrieve a parent by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            if (_specialRepo is not null)
            {
                var specialist = await _specialRepo.GetBy(id);
                if (specialist is not null)
                {
                    return Ok(specialist);
                }
            }
            return BadRequest("A szakember adatai elérhetetlenek!");
        }
    }
}
