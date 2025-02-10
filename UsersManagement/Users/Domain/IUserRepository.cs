

namespace UsersManagement.Users.Domain
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> SearchUsers();
        Task<bool> CreateUser(User user);
        Task<bool> UpdateUser(User user);
        
        Task<User> FindUser(int id);

    }
}
