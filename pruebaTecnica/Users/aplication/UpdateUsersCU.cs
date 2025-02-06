using pruebaTecnica.Users.domain;

namespace pruebaTecnica.Users.aplication
{
    public class UpdateUsersCU
    {
        private readonly IUserRepository _userRepository;

        public UpdateUsersCU(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Update(User user)
        {
            return await _userRepository.UpdateUser(user);
        }
    }
}
