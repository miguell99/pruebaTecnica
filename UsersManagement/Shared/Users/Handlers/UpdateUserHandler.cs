using MediatR;
using UsersManagement.Users.Domain;
using UsersManagement.Users.Infrastructure.Commands;

namespace UsersManagement.Users.Application.Handlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserComand, bool>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository ;
        }

        public async Task<bool> Handle(UpdateUserComand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Id = request.Id,
                Email = request.Email,
                UserName = request.UsernName
            };

            return await _userRepository.UpdateUser(user);

        }
    }
}
