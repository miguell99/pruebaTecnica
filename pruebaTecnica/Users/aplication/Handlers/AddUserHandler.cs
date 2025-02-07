using MediatR;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Commands;

namespace pruebaTecnica.Users.aplication.Handlers
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;

        public AddUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Email = request.Email,
                UserName = request.UserName
            };
            return await _userRepository.AddUser(user);
        }
    }
}
