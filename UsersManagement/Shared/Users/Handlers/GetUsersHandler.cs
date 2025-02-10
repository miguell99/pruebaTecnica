using MediatR;
using UsersManagement.Users.Application.DTO;
using UsersManagement.Users.Domain;
using UsersManagement.Users.Infrastructure.Queries;

namespace UsersManagement.Users.Application.Handlers
{
    /*
    public class GetUsersHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDTO>>
    {
        private readonly IUserRepository _userRepository;

        public GetUsersHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<IEnumerable<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUsers();
        }
    }
    */
}
