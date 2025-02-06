using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.domain;

namespace pruebaTecnica.Users.infraestructure
{
    [ApiController]
    [Route("[controller]")]
    public class AddUsersController : ControllerBase
    {
        private readonly AddUsersCU _addUsersCu;
        public AddUsersController(AddUsersCU addUsersCu)
        {
            _addUsersCu = addUsersCu;
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers([FromBody] User user)
        {
            var created = await _addUsersCu.Add(user);


            return Created("created", created);
        }
    }
}
