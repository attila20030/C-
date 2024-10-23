using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaceController : ControllerBase
    {
        private readonly IPlaceRepo _placeRepo;

        // Constructor to inject the IParentRepo dependency
        public PlaceController(IPlaceRepo placeRepo)
        {
            _placeRepo = placeRepo;
        }

        // GET method to retrieve all parents
        [HttpGet]
        public async Task<IActionResult> SelectAllParentAsync()
        {
            if (_placeRepo is not null)
            {
                var parents = await _placeRepo.GetAll();
                return Ok(parents);
            }
            return BadRequest("A szülő adatai elérhetetlenek!");
        }

        // GET method to retrieve a parent by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            if (_placeRepo is not null)
            {
                var place = await _placeRepo.GetBy(id);
                if (place is not null)
                {
                    return Ok(place);
                }
            }
            return BadRequest("A szülő adatai elérhetetlenek!");
        }
    }
}
