using MediatR;
using pruebaTecnica.Users.aplication.DTO;

namespace pruebaTecnica.Users.infraestructure.Queries
{
    public record GetAllUsersQuery: IRequest<IEnumerable<UserDTO>>;
}
