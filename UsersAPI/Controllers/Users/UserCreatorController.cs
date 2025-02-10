using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Users.Application.Create;
using UsersManagement.Users.Domain;
using UsersManagement.Users.Infrastructure.Commands;

namespace UsersAPI.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserCreatorController : ControllerBase
    {
        //private readonly IMediator _mediator;
        private readonly UserCreator _userCreator;

        public UserCreatorController(UserCreator userCreator)
        {
            _userCreator = userCreator;
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers([FromBody] User user)
        {
            //var created = await _addUsersCu.Add(user);
            var created = await _userCreator.CreateUser(user);

            return Created("created", created);
        }
    }
}
