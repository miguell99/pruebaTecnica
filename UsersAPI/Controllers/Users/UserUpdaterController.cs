using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Users.Application.Update;
using UsersManagement.Users.Domain;
using UsersManagement.Users.Infrastructure.Commands;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserUpdaterController : Controller
    {
        private readonly UserUpdater _userUpdater;

        public UserUpdaterController(UserUpdater userUpdater)
        {
            _userUpdater = userUpdater;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            await _userUpdater.UpdateUser(user);
            return NoContent();
        }
    }
}
