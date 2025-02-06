using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.Users.aplication;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetUsersController : ControllerBase
    {
        private readonly GetUsersCU _getUsersCu;

        public GetUsersController(GetUsersCU getUsersCu)
        {
            _getUsersCu = getUsersCu;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _getUsersCu.Get();
            return Ok(users);
        }
    }
}
