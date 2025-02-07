using MySqlConnector;
using Dapper;
using pruebaTecnica.Users.aplication.DTO;

namespace pruebaTecnica.Users.domain
{
    public class UserRepository : IUserRepository
    {

        const string connectionString = "server=localhost;port=3306;database=userdb2;uid=root;password=password9";




        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "SELECT * FROM user";
                return await connection.QueryAsync<UserDTO>(sql, new { });
            }

        }

        public async Task<bool> AddUser(User user)
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "INSERT INTO user (email, username) VALUES (@Email, @UserName)";
                var result = await connection.ExecuteAsync(sql, new { user.Email, user.UserName });
                return result > 0;
            }



        }

        public async Task<bool> UpdateUser(User user)
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "UPDATE user SET email=@Email, username = @UserName WHERE id = @Id";
                var result = await connection.ExecuteAsync(sql, new { user.Email, user.UserName, user.Id });
                return result > 0;
            }
        }
    }
}
