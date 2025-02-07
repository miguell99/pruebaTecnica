using pruebaTecnica.Users.aplication.DTO;

namespace pruebaTecnica.Users.domain
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDTO>> GetUsers();
        Task<bool> AddUser(User user);
        Task<bool> UpdateUser(User user);

    }
}
