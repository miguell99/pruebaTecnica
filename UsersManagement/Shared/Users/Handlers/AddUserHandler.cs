using MediatR;
using UsersManagement.Users.Domain;
using UsersManagement.Users.Infrastructure.Commands;

namespace UsersManagement.Shared.Users.Handlers
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
            return await _userRepository.CreateUser(user);
        }
    }
}
