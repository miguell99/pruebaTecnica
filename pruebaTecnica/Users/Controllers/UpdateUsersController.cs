using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.domain;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateUsersController : Controller
    {
        private readonly UpdateUsersCU _updateUsersCu;

        public UpdateUsersController(UpdateUsersCU updateUsersCu)
        {
            _updateUsersCu = updateUsersCu;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] User user)
        {
            await _updateUsersCu.Update(user);
            return NoContent();
        }
    }
}
