using MediatR;
using pruebaTecnica.Users.aplication.DTO;

namespace pruebaTecnica.Users.infraestructure.Commands
{
    public record AddUserCommand(string Email, string UserName) : IRequest<UserDTO>;
}
