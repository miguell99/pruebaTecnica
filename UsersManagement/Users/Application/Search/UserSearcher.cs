using UsersManagement.Users.Domain;

namespace UsersManagement.Users.Application.Search;

public class UserSearcher
{
    private readonly IUserRepository _userRepository;

    public UserSearcher(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> SearchUsers()
    {
        return await _userRepository.SearchUsers();
    }
}