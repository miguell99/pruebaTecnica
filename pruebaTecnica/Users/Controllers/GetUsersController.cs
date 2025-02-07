using MediatR;
using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.infraestructure.Queries;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetUsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GetUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());
            return Ok(users);
        }
    }
}
