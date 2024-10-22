using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllTeacherAsync()
        {
            List<User>? users = new();
            if (_userRepo is not null)
            {
                users = await _userRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Tanár adatok elérhetetlenek!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            User? users = new();
            if (_userRepo is not null)
            {
                users = await _userRepo.GetBy(id);
                if (users is not null)
                    return Ok(users);
            }
            return BadRequest("Tanár adatok elérhetetlenek");

        }
    }
}
