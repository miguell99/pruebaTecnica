using MediatR;
using pruebaTecnica.Users.aplication.DTO;

namespace pruebaTecnica.Users.infraestructure.Commands
{

    public record UpdateUserComand(int Id, string Email, string UsernName) : IRequest<bool>;

}
