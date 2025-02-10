using UsersManagement.Users.Domain;

namespace UsersManagement.Users.Application.Find;

public class UserFinder
{
    private readonly IUserRepository _userRepository;

    public UserFinder(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> FindUser(int userId)
    {
        var result = await _userRepository.FindUser(userId);
        if (!(result is null))
        {
            throw new InvalidCastException();
        }

        return result;
    }
}