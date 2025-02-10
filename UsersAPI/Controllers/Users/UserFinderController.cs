using Microsoft.AspNetCore.Mvc;
using UsersManagement.Users.Application.Find;
using UsersManagement.Users.Domain;

namespace UsersAPI.Controllers.Users;

[ApiController]
[Route("[controller]")]
public class UserFinderController : ControllerBase
{
    private readonly UserFinder _userFinder;

    public UserFinderController(UserFinder userFinder)
    {
        _userFinder = userFinder;
    }
    [HttpGet]
    public async Task<IActionResult> FindUser([FromQuery] int userId)
    {
        try
        {
            var result = await _userFinder.FindUser(userId);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
}