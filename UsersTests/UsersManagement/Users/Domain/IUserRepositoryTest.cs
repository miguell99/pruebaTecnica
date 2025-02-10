

namespace UserTests.Users.Domain
{
    public interface IUserRepositoryTest
    {
        Task<IEnumerable<UserTest>> SearchUsers();
        Task<bool> CreateUser(UserTest userTest);
        Task<bool> UpdateUser(UserTest userTest);
        
        Task<UserTest> FindUser(int id);

    }
}
