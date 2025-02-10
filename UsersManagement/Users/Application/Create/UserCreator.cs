using UsersManagement.Users.Domain;

namespace UsersManagement.Users.Application.Create;

public class UserCreator
{
    private readonly IUserRepository _userRepository;

    public UserCreator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<bool> CreateUser(User user)
    {
        return _userRepository.CreateUser(user);
    }
    
    
}