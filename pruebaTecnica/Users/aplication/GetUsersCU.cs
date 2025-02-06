using pruebaTecnica.Users.domain;

namespace pruebaTecnica.Users.aplication
{
    public class GetUsersCU
    {
        private readonly IUserRepository _userRepository;

        public GetUsersCU(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Get()
        { 
            return await _userRepository.GetUsers();
        }
    }
}
