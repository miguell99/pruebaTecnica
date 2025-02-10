using MediatR;
using UsersManagement.Users.Application.DTO;

namespace UsersManagement.Users.Infrastructure.Queries
{
    public record GetAllUsersQuery: IRequest<IEnumerable<UserDTO>>;
}
