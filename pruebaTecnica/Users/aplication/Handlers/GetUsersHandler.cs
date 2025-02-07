using MediatR;
using pruebaTecnica.Users.aplication.DTO;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Queries;

namespace pruebaTecnica.Users.aplication.Handlers
{
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
}
