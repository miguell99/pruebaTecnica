using Microsoft.Extensions.Configuration;
using UsersManagement.Users.Domain;

namespace UsersManagement.Users.Application.Update;

public class UserUpdater
{
    private readonly IUserRepository _userRepository;

    public UserUpdater(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> UpdateUser(User user)
    {
        return await _userRepository.UpdateUser(user);
    }
}