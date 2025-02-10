using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Users.Application.Search;
using UsersManagement.Users.Infrastructure.Queries;

namespace pruebaTecnica.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserSearcherController : ControllerBase
    {
        private readonly UserSearcher _userSearcher;

        public UserSearcherController(UserSearcher userSearcher)
        {
            _userSearcher = userSearcher;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userSearcher.SearchUsers();
            return Ok(users);
        }
    }
}
