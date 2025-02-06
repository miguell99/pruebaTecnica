using pruebaTecnica.Users.domain;

namespace pruebaTecnica.Users.aplication
{
    public class AddUsersCU
    {
        private readonly IUserRepository _userRepository;

        public AddUsersCU(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Add(User user)
        {
            return await _userRepository.AddUser(user);
        }
    }
}
