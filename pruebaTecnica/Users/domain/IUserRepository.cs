namespace pruebaTecnica.Users.domain
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<bool> AddUser(User user);
        Task<bool> UpdateUser(User user);

    }
}
