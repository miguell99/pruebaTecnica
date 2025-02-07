using MediatR;
using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.aplication.Handlers;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Commands;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddUsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        

        public AddUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers(AddUserCommand command)
        {
            //var created = await _addUsersCu.Add(user);
            var created = await _mediator.Send(command);

            return Created("created", created);
        }
    }
}
