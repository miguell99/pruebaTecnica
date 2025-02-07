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

        
    }
}
