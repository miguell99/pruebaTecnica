using MediatR;

namespace UsersManagement.Users.Infrastructure.Commands
{
    public record AddUserCommand(string Email, string UserName) : IRequest<bool>;
}
