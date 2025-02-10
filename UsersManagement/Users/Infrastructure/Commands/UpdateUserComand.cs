using MediatR;

namespace UsersManagement.Users.Infrastructure.Commands
{

    public record UpdateUserComand(int Id, string Email, string UsernName) : IRequest<bool>;

}
