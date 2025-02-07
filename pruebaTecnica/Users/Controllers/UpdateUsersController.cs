using MediatR;
using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Commands;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateUsersController : Controller
    {
        private readonly IMediator _mediator;

        public UpdateUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserComand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
